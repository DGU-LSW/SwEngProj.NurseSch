using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*
 * 원본: http://slaner.tistory.com/52
 * 수정: 임제희
 * Module: ClientSocket
 * LOC: 506
 */
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

			ConnectToServer("localhost", 12);
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

			gConnected = isConnected;

			if(isConnected)
			{
				// 4096 바이트의 크기의 바이트배열을 갖는 AsyncObject 클래스 생성
				AsyncObject ao = new AsyncObject(4096);

				ao.workingSocket = mClientSocket;
				mClientSocket.BeginReceive(ao.buffer, 0, ao.buffer.Length, SocketFlags.None, mfnReceiveHandler, ao);

				MessageBox.Show("연결에 성공했습니다!");
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

		#region 만든 부분 : 서버와 통신하는 메소드

		/* 서버와 Message 통신방식 : 코드,구성요소,구성요소,요소수
		 * 코드 : 무슨 내용인지, 써야하는 함수를 파악하기위한 코드번호
		 * 요소수 : 코드와 구성요소 갯수의 합. 구성요소 2개라면 3이다.
		 * 
		 * 실세 사용
		 * 로그인 메시지		: LOGIN|ID|PW|요소수
		 * 아이디찾기		: FINDID|이름|라이센스번호|요소수
		 * 비밀번호찾기		: FINDPW|아이디|이름|라이센스번호|요소수
		 * 오프신청			: REGOFF|ID|날짜|날짜|날짜|요소수
		 * 오프리스트요구		: CALLOFFLIST|
		 * 간호사리스트요구	: CALLNURSELIST|
		 * 옵션 요구			: GETOP|
		 * 옵션 저장			: SAVEOP|option.tostring
		 * 개인정보 수정		: MODIF|nurse.tostring|...
		 * 월계획 저장하기	: SAVESCH|월계획 toString()|요소수
		 * 월계획 가져오기	: GETSCH|
		 * 간호사정보가져오기	: GETNURSE|id
		 * 간호사 등록		: REGNURSE|nurse.tostring|
		 */

		//ID, PW를 보내서 로그인 시도
		//0은 실패, 1은 chief, 2는 general
		public virtual int logIn(string ID, string PW)
        {
			SendMessage("LOGIN|" + ID + '|' + PW + '|' + 3);
			
			while(true) { if(messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return 0;
			}

			if (messageReturned == "FAIL")
			{
				MessageBox.Show("로그인 실패!");

				messageReturned = null;

				return 0;
			}

			Nurse returnMessage = new Nurse(messageReturned);

			messageReturned = null;

			if(returnMessage.IsChiefNurse){ return 1; }
			else { return 2; }
        }

		//id찾기에 답을 돌려줄 함수
		public virtual Nurse ReturnInfo(string name, string lisenceNumber)
		{
			SendMessage("FINDID|" + name + '|' + lisenceNumber);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				messageReturned = null;

				return null;
			}

			if (messageReturned == "FAIL")
			{
				MessageBox.Show("잘못 입력하셨습니다!");

				messageReturned = null;

				return null;
			}

			Nurse result = new Nurse(messageReturned);

			messageReturned = null;

			return result;
		}

		//비밀번호 찾기에 답을 들려줄 함수
		public virtual Nurse ReturnInfo(string id, string name, string lisenceNumber)
		{
			SendMessage("FINDPW|" + id + '|' + name + '|' + lisenceNumber);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				messageReturned = null;

				return null;
			}

			if (messageReturned == "FAIL")
			{
				MessageBox.Show("잘못 입력하셨습니다!");

				messageReturned = null;

				return null;
			}

			Nurse result = new Nurse(messageReturned);

			messageReturned = null;

			return result;
		}

		// 신청할 off를 서버로 보낸다.
		// 성공이면 true 실패면 false
		// 각 offlist의 요소들은 |로 연결한다.
		public virtual bool sendOff(List<Off> offList)
		{
			string message = "REGOFF|";

			message += offList[0].ToString();

			for(int i=1;i<offList.Count;i++)
			{
				message += "|" + offList[i].ToString();

				i++;
			}

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				messageReturned = null;

				return false;
			}

			if (messageReturned.Equals("FAIL"))
			{
				MessageBox.Show("잘못 입력하셨습니다!");

				messageReturned = null;

				return false;
			}

			messageReturned = null;

			return true;
		}

		//서버에 저장된 Off 목록을 가지고 온다.
		public virtual List<Off> getOffList()
        {
			string message = "CALLOFFLIST|";

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");
				messageReturned = null;
				return null;
			}

			if (messageReturned.Equals("FAIL"))
			{
				MessageBox.Show("잘못 입력하셨습니다!");
				messageReturned = null;
				return null;
			}

			string[] msgArray = messageReturned.Split('|');

			List<Off> result = new List<Off>();

			for(int i=0;i<msgArray.Length;i++)
			{
				Off newOff = new Off(msgArray[i]);
				result.Add(newOff);
			}
			messageReturned = null;
			return result;
        }

        //서버에 있는 nurse 목록을 가지고 온다.
        public virtual List<Nurse> getNurseList()
        {
			string message = "CALLNURSELIST|";

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");
				messageReturned = null;
				return null;
			}

			if (messageReturned.Equals("FAIL"))
			{
				MessageBox.Show("잘못 입력하셨습니다!");
				messageReturned = null;
				return null;
			}

			string[] msgArray = messageReturned.Split('|');

			List<Nurse> result = new List<Nurse>();

			for (int i = 0; i < msgArray.Length; i++)
			{
				Nurse newOff = new Nurse(msgArray[i]);

				result.Add(newOff);
			}
			messageReturned = null;
			return result;
		}
        
        //서버에 있는 option을 가지고 온다.
        public virtual Option getOption()
        {
			string message = "GETOP|";

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");
				messageReturned = null;
				return null;
			}

			if (messageReturned.Equals("FAIL"))
			{
				MessageBox.Show("잘못 입력하셨습니다!");
				messageReturned = null;
				return null;
			}

			Option result = null;

			if (messageReturned != "FAIL")
			{
				result = new Option(messageReturned);
			}
			messageReturned = null;
			return result;
        }
        
        //서버에 option을 저장한다.
        //성공하면 true 실패하면 false
        public virtual bool setOption(Option option)
        {
			string message = "SAVEOP|" + option.ToString();

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");
				messageReturned = null;
				return false;
			}

			bool result;

			if (messageReturned == "SUCCESS")
			{

				result = true;
			}
			else
			{
				MessageBox.Show("잘못 입력하셨습니다!");

				result = false;
			}

			messageReturned = null;

			return result;
		}

		//개인정보 수정한 것을 서버로 보낸다.
		//성공하면 true 실패하면 false
		// id는 개인정보를 수정할 간호사의 id, nurse는 수정된 개인정보
		public virtual bool modifyNurse(string ID, Nurse nurse, List<Nurse> nurseList)
		{
			string message = "MODIF|";

			for(int i=0;i<nurseList.Count;i++)
			{
				if(nurseList[i].ID == nurse.ID)
				{
					nurseList[i].Password = nurse.Password;
					nurseList[i].LicenseNum = nurse.LicenseNum;
					nurseList[i].PhoneNum = nurse.PhoneNum;
					nurseList[i].Group = nurse.Group;
					nurseList[i].IsChiefNurse = nurse.IsChiefNurse;

					break;
				}
			}

			message += nurseList[0].ToString();

			for (int i = 1; i < nurseList.Count; i++)
			{
				message += "|" + nurseList[i].ToString();
			}

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");
				messageReturned = null;
				return false;
			}

			bool result;

			if(messageReturned == "SUCCESS")
			{
				result = true;
			}
			else
			{
				MessageBox.Show("작업 실패!");

				result = false;
			}
			messageReturned = null;

			return result;
		}

		//서버에 schedule을 보낸다.
		//성공하면 true 실패하면 false
		public virtual bool sendMonthSchedule(MonthSchedule schedule)
        {
			string message = "SAVESCH|";
			message += schedule.ToString();

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");
				messageReturned = null;
				return false;
			}

			bool result;

			if (messageReturned == "SUCCESS")
			{
				result = true;
			}
			else
			{
				MessageBox.Show("작업 실패!");

				result = false;
			}

			messageReturned = null;

			return result;
		}

        //서버에 있는 schedule를 가지고 온다.
        //ex) year = 2016 month = 03
        public virtual MonthSchedule getMonthSchedule(string year, string month)
        {
			string message = "GETSCH|";

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				messageReturned = null;

				return null;
			}
			MonthSchedule result;
			if (messageReturned == "SUCCESS")
			{
				result = new MonthSchedule(messageReturned);
			}
			else
			{
				MessageBox.Show("작업 실패!");

				result = null;
			}

			return result;
		}

		//ID에 해당하는 nurse 정보를 가지고 온다.
		public virtual Nurse getNurse(string ID)
		{
			string message = "GETNURSE|" + ID;

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				messageReturned = null;

				return null;
			}

			Nurse newNurse;

			if (messageReturned != "FAIL")
			{
				newNurse = new Nurse(messageReturned);
			}
			else
			{
				MessageBox.Show("작업 실패!");

				newNurse = null;
			}

			messageReturned = null;

			return newNurse;
		}

		// 간호사 등록
		public virtual bool RegisterNurse(Nurse newNurse)
		{
			string message = "REGNURSE|" + newNurse.ToString();

			SendMessage(message);

			while (true) { if (messageReturned != null) { break; } }

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				messageReturned = null;

				return false;
			}

			bool result;
			if (messageReturned == "SUCCESS")
			{
				MessageBox.Show("전송시간 초과!");

				result = true;
			}
			else
			{
				MessageBox.Show("작업 실패!");

				result = false;
			}

			return result;
		}

		#endregion
	}
}