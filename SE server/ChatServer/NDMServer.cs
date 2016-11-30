﻿using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace NurseManagerServer
{
	public class NDMServer
	{
		public class AsyncObject
		{
			public Byte[] Buffer;
			public Socket WorkingSocket;
			public AsyncObject(Int32 bufferSize)
			{
				this.Buffer = new Byte[bufferSize];
			}
		}

		Socket m_ConnectedClient = null;
		Socket m_ServerSocket = null;
		AsyncCallback m_fnReceiveHandler;
		AsyncCallback m_fnSendHandler;
		AsyncCallback m_fnAcceptHandler;


		public NDMServer()
		{

			// 비동기 작업에 사용될 대리자를 초기화합니다.
			m_fnReceiveHandler = new AsyncCallback(handleDataReceive);
			m_fnSendHandler = new AsyncCallback(handleDataSend);
			m_fnAcceptHandler = new AsyncCallback(handleClientConnectionRequest);

		}

		// TCP 통신소켓을 생성하고, 포트를 바인딩.
		// 연결요청을 기다리고, 비동기적으로 처리.
		// 처리하는 함수는 handleClientConnectionRequest
		public void StartServer(UInt16 port)
		{
			m_ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
			m_ServerSocket.Bind(new IPEndPoint(IPAddress.Any, port));
			m_ServerSocket.Listen(5);
			m_ServerSocket.BeginAccept(m_fnAcceptHandler, null);
		}

		// 소켓 종료
		public void StopServer() { m_ServerSocket.Close();}

		public void SendMessage(String message)
		{
			AsyncObject ao = new AsyncObject(1);
			ao.Buffer = Encoding.Unicode.GetBytes(message);
			ao.WorkingSocket = m_ConnectedClient;

			try
			{
				m_ConnectedClient.BeginSend(ao.Buffer, 0, ao.Buffer.Length, SocketFlags.None, m_fnSendHandler, ao);
			}
			catch (Exception ex)
			{
				Console.WriteLine("전송 중 오류 발생!\n메세지: {0}", ex.Message);
			}
		}

		// 사용자로부터의 연결요청을 다루는 함수
		private void handleClientConnectionRequest(IAsyncResult ar)
		{
			Socket sockClient;
			try
			{
				sockClient = m_ServerSocket.EndAccept(ar);
			}
			catch (Exception ex)
			{
				Console.WriteLine("연결 수락 도중 오류 발생! 메세지: {0}", ex.Message);
				return;
			}

			AsyncObject ao = new AsyncObject(4096);
			ao.WorkingSocket = sockClient;
			m_ConnectedClient = sockClient;

			try
			{
				sockClient.BeginReceive(ao.Buffer, 0, ao.Buffer.Length, SocketFlags.None, m_fnReceiveHandler, ao);
			}
			catch (Exception ex)
			{
				Console.WriteLine("자료 수신 대기 도중 오류 발생! 메세지: {0}", ex.Message);
				return;
			}
		}

		// 들어오는 데이터를 다루는 메소드
		private void handleDataReceive(IAsyncResult ar)
		{
			AsyncObject ao = (AsyncObject)ar.AsyncState;
			int recvBytes; // 들어오는 데이터의 바이트 수

			try
			{
				recvBytes = ao.WorkingSocket.EndReceive(ar);
			}
			catch
			{
				return;
			}

			if (recvBytes > 0)
			{
				Byte[] msgByte = new Byte[recvBytes];
				Array.Copy(ao.Buffer, msgByte, recvBytes);
				string message = Encoding.Unicode.GetString(msgByte);

				Console.WriteLine(DateTime.Now.ToString() + "|" + message);

				SendMessage(BuildMessage(message));

				Console.WriteLine();
			}

			try
			{
				ao.WorkingSocket.BeginReceive(ao.Buffer, 0, ao.Buffer.Length, SocketFlags.None, m_fnReceiveHandler, ao);
			}
			catch (Exception ex)
			{
				Console.WriteLine("자료 수신 대기 도중 오류 발생! 메세지: {0}", ex.Message);
				return;
			}
		}

		// 보낸 데이터 관리. 오류나면 오류 보고, 
		private void handleDataSend(IAsyncResult ar)
		{
			AsyncObject ao = (AsyncObject)ar.AsyncState;
			int sentBytes; // 전송한 문자열의 바이트 수

			try
			{
				sentBytes = ao.WorkingSocket.EndSend(ar);
			}
			catch (Exception ex)
			{
				Console.WriteLine("자료 송신 도중 오류 발생! 메세지: {0}", ex.Message);

				return;
			}

			if (sentBytes > 0)
			{
				Byte[] msgByte = new Byte[sentBytes];
				Array.Copy(ao.Buffer, msgByte, sentBytes);

				Console.WriteLine("메세지 보냄: {0}", Encoding.Unicode.GetString(msgByte));
			}
		}

		// 받은 메시지를 기반으로 보낼 메시지 생성
		private string BuildMessage(string messageReceived)
		{
			// 내가 추가한 부분
			List<NurseDutyManager.Nurse> nurseList;
			List<NurseDutyManager.Off> offList;
			string result = "FAIL";
			string[] msgArray = messageReceived.Split('|');
			string fileReadResult;
			string savePath;
			System.IO.StreamReader readFile;

			switch (msgArray[0])
			{
				case "LOGIN":
					savePath = @"Data\nurse.txt";
					readFile = new System.IO.StreamReader(savePath);

					nurseList = new List<NurseDutyManager.Nurse>();

					while ((fileReadResult = readFile.ReadLine()) != null)
					{
						NurseDutyManager.Nurse newNurse = new NurseDutyManager.Nurse(fileReadResult);
						nurseList.Add(newNurse);
					}

					for (int i = 0; i < nurseList.Count; i++)
					{
						if (nurseList[i].ID == msgArray[1] && nurseList[i].Password == msgArray[2])
						{
							result = nurseList[i].ToString();

							break;
						}
						else
						{
							result = "FAIL";
						}
					}
					break;

				case "FINDID":
					savePath = @"Data\nurse.txt";
					readFile = new System.IO.StreamReader(savePath);

					nurseList = new List<NurseDutyManager.Nurse>();

					while ((fileReadResult = readFile.ReadLine()) != null)
					{
						NurseDutyManager.Nurse newNurse = new NurseDutyManager.Nurse(fileReadResult);
						nurseList.Add(newNurse);
					}

					for (int i = 0; i < nurseList.Count; i++)
					{
						if (nurseList[i].Name == msgArray[1] && nurseList[i].LicenseNum == msgArray[2])
						{
							result = nurseList[i].ToString();

							break;
						}
						else
						{
							result = "FAIL";
						}
					}
					break;

				case "FINDPW":
					savePath = @"Data\nurse.txt";
					readFile = new System.IO.StreamReader(savePath);

					nurseList = new List<NurseDutyManager.Nurse>();

					while ((fileReadResult = readFile.ReadLine()) != null)
					{
						NurseDutyManager.Nurse newNurse = new NurseDutyManager.Nurse(fileReadResult);
						nurseList.Add(newNurse);
					}

					for (int i = 0; i < nurseList.Count; i++)
					{
						if (nurseList[i].ID == msgArray[1] && nurseList[i].Name == msgArray[2] && nurseList[i].LicenseNum == msgArray[3])
						{
							result = nurseList[i].ToString();

							break;
						}
						else
						{
							result = "FAIL";
						}
					}
					break;

				case "REGOFF":
					offList = new List<NurseDutyManager.Off>();

					for (int i = 0; i < msgArray.Length - 1; i++)
					{
						NurseDutyManager.Off newOff = new NurseDutyManager.Off(msgArray[i+1]);
						offList.Add(newOff);
					}

					savePath = @"Data/offList.txt";

					for (int i = 0; i < offList.Count; i++)
					{
						//writeFile.WriteLine(offList[i].ToString() + "\r\n");

						System.IO.File.AppendAllText(savePath, offList[i].ToString() + "\r\n", Encoding.Unicode);
					}
					
					result = "SUCCESS";

					break;

				case "CALLOFFLIST":
					savePath = @"Data\offList.txt";
					readFile = new System.IO.StreamReader(savePath);

					offList = new List<NurseDutyManager.Off>();
					
					Console.WriteLine("Off String to send");
					
					while ((fileReadResult = readFile.ReadLine()) != null)
					{
						NurseDutyManager.Off newOff = new NurseDutyManager.Off(fileReadResult);
						Console.WriteLine(newOff.ToString());
						offList.Add(newOff);
					}

					result =  offList[0].ToString();

					for (int i = 1; i < offList.Count; i++)
					{
						result += '|' + offList[i].ToString();
					}
					break;

				case "CALLNURSELIST":
					savePath = @"Data\nurse.txt";
					readFile = new System.IO.StreamReader(savePath);

					nurseList = new List<NurseDutyManager.Nurse>();

					Console.WriteLine("Nurse String to send");
					while ((fileReadResult = readFile.ReadLine()) != null)
					{
						NurseDutyManager.Nurse newNurse = new NurseDutyManager.Nurse(fileReadResult);
						Console.WriteLine(newNurse.ToString());
						nurseList.Add(newNurse);
					}

					result = nurseList[0].ToString();

					for (int i = 1; i < nurseList.Count; i++)
					{
						result += '|' + nurseList[i].ToString();
					}
					break;
				case "GETOP":
					savePath = @"Data\option.txt";
					readFile = new System.IO.StreamReader(savePath);
					result = readFile.ReadLine();

					break;
				case "SAVEOP":
					savePath = @"Data/option.txt";

					System.IO.File.WriteAllText(savePath, msgArray[1], Encoding.Unicode);
					
					result = "SUCCESS";
					break;
			}

			return result;
		}
	}
}