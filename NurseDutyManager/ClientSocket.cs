using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace NurseDutyManager
{
    public class ClientSocket
	{
		string messageReturned;

		#region 가져온 부분

		public class AsyncObject
		{
			public byte[] buffer;
			public Socket workingSocket;
			public AsyncObject(int bufferSize)
			{
				this.buffer = new byte[bufferSize];
			}
		}

		bool gConnected;
		Socket mClientSocket = null;
		AsyncCallback mfnReceiveHandler;
		AsyncCallback mfnSenderHandler;


		public ClientSocket()
		{
			mfnReceiveHandler = new AsyncCallback(handleDataReceive);
			mfnSenderHandler = new AsyncCallback(handleDataSend);
		}

		public bool Conntected
		{
			get { return gConnected; }
		}

		public void ConnectToServer(string hostname, UInt16 hostPort)
		{
			mClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

			bool isConnected = false;

			try
			{
				mClientSocket.Connect(hostname, hostPort);
				isConnected = true;
			}
			catch(Exception e)
			{
				isConnected = false;
			}

			if(isConnected)
			{
				// 4096 바이트의 크기의 바이트배열을 갖는 AsyncObject 클래스 생성
				AsyncObject ao = new AsyncObject(4096);

				ao.workingSocket = mClientSocket;
				mClientSocket.BeginReceive(ao.buffer, 0, ao.buffer.Length, SocketFlags.None, mfnReceiveHandler, ao);
			}
			else
			{
				MessageBox.Show("연결에 실패했습니다!");
			}
		}

		public void StopClient()
		{
			mClientSocket.Close();
		}

		public void SendMessage(string message)
		{
			AsyncObject ao = new AsyncObject(1);
			ao.buffer = Encoding.Unicode.GetBytes(message);
			ao.workingSocket = mClientSocket;

			try
			{
				mClientSocket.BeginSend(ao.buffer, 0, ao.buffer.Length, SocketFlags.None, mfnSenderHandler, ao);
			}
			catch(Exception e)
			{
				MessageBox.Show("전송 중 오류 발생!\r\n:{0}", e.Message);
			}
		}

		public void handleDataReceive(IAsyncResult ar)
		{
			AsyncObject ao = (AsyncObject)ar.AsyncState;

			int recvBytes;

			try
			{
				recvBytes = ao.workingSocket.EndReceive(ar);
			}
			catch
			{
				return;
			}

			if(recvBytes > 0)
			{
				byte[] msgByte = new byte[recvBytes];
				Array.Copy(ao.buffer, msgByte, recvBytes);

				messageReturned = Encoding.Unicode.GetString(msgByte);
			}

			try
			{
				ao.workingSocket.BeginReceive(ao.buffer, 0, ao.buffer.Length, SocketFlags.None, mfnReceiveHandler, ao);
			}
			catch(Exception ex)
			{
				MessageBox.Show("자료 수신 대기 도중 오류 발생! 메시지:{0}", ex.Message);

				return;
			}
		}

		public void handleDataSend(IAsyncResult ar)
		{
			AsyncObject ao = (AsyncObject)ar.AsyncState;

			int sentBytes;

			try
			{
				sentBytes = ao.workingSocket.EndSend(ar);
			}
			catch(Exception e)
			{
				MessageBox.Show("자료 송신 도중 오류 발생! 메시지:{0}", e.Message);

				return;
			}

			if(sentBytes > 0)
			{
				byte[] msgByte = new byte[sentBytes];
				Array.Copy(ao.buffer, msgByte, sentBytes);
			}
		}

		#endregion

		#region 만든 부분

		//ID, PW를 보내서 로그인 시도
		//0은 실패, 1은 chief, 2는 general
		public int logIn(string ID, string PW)
        {
            int result = 0;

			try
			{

			}
			catch(Exception e)
			{

			}

			return result;
        }

        //서버에 저장된 Off 목록을 가지고 온다.
        public List<Off> getOffList()
        {
            List<Off> result = null;
            return result;
        }

        //신청할 off를 서버로 보낸다.
        //성공이면 true 실패면 false
        public bool sendOff(Off off)
        {
            bool result = false;
            return result;
        }

        //서버에 있는 nurse 목록을 가지고 온다.
        public List<Nurse> getNurseList()
        {
            List<Nurse> list = null;
            return list;
        }

        //ID에 해당하는 nurse 정보를 가지고 온다.
        public Nurse getNurse(string ID)
        {
            Nurse result = null;
            return result;
        }

        //개인정보 수정한 것을 서버로 보낸다.
        //성공하면 true 실패하면 false
        public bool modifyNurse(string ID, Nurse nurse)
        {
            bool result = false;
            return result;
        }
        
        //서버에 있는 option을 가지고 온다.
        public Option getOption()
        {
            Option result = null;
            return result;
        }
        
        //서버에 option을 저장한다.
        //성공하면 true 실패하면 false
        public bool setOption(Option option)
        {
            bool result = false;
            return result;
        }

        //서버에 schedule을 보낸다.
        //성공하면 true 실패하면 false
        public bool sendMonthSchedule(MonthSchedule schedule)
        {
            bool result = false;
            return result;
        }

        //서버에 있는 schedule를 가지고 온다.
        //ex) year = 2016 month = 03
        public MonthSchedule getMonthSchedule(string year, string month)
        {
            MonthSchedule result = null;
            return result;
        }

		//id찾기에 답을 돌려줄 함수
		public Nurse ReturnInfo(string name, string lisenceNumber)
		{
			Nurse result;

			SendMessage("findID," + name + ',' + lisenceNumber);

			int i = 0;

			while(messageReturned == null && i < 1000)
			{
				i++;
			}

			if(messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return null;
			}

			result = new Nurse(messageReturned);

			return result;
		}

		//비밀번호 찾기에 답을 들려줄 함수
		public Nurse ReturnInfo(string id, string name, string lisenceNumber)
		{
			Nurse result;

			SendMessage("findPW," + id + ',' + name + ',' + lisenceNumber);

			int i = 0;

			while (messageReturned == null && i < 1000)
			{
				i++;
			}

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return null;
			}

			result = new Nurse(messageReturned);

			return result;
		}

		#endregion
	}
}
