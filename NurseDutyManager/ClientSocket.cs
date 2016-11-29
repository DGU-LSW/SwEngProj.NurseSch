using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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

			this.ConnectToServer("localhost", 12);
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

		#region 만든 부분

		#region 서버와 통신하는 메소드를 다루는 부분
		/* 서버와 Message 통신방식 : 코드,구성요소,구성요소,요소수
		 * 코드 : 무슨 내용인지, 써야하는 함수를 파악하기위한 코드번호
		 * 요소수 : 코드와 구성요소 갯수의 합. 구성요소 2개라면 3이다.
		 * 
		 * 실세 사용
		 * 로그인 메시지	: LOGIN|ID|PW|요소수
		 * 오프신청		: OFF|ID|날짜|날짜|날짜|요소수
		 * 아이디찾기	: FINDID|이름|라이센스번호|요소수
		 * 비밀번호찾기	: FINDPW|아이디|이름|라이센스번호|요소수
		 * 월계획 보내기	: SAVESCH|월계획 toString()|요소수
		 */

		//ID, PW를 보내서 로그인 시도
		//0은 실패, 1은 chief, 2는 general
		public virtual int logIn(string ID, string PW)
        {
			SendMessage("LOGIN|" + ID + '|' + PW + '|' + 3);

			//int i = 0;

			Thread.Sleep(3000);
			
			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return 0;
			}
			
			if(messageReturned.Equals("FAIL"))
			{
				MessageBox.Show("로그인 실패!");
			}

			Nurse returnMessage = new Nurse(messageReturned);

			if(returnMessage.IsChiefNurse) { return 1; }
			else { return 2; }
        }

        //서버에 저장된 Off 목록을 가지고 온다.
        public virtual List<Off> getOffList()
        {
            List<Off> result = null;
            return result;
        }

        //신청할 off를 서버로 보낸다.
        //성공이면 true 실패면 false
		//각 offlist의 요소들은 |로 연결한다.
        public virtual bool sendOff(List<Off> offList)
        {
			string message = "OFF|";
			message += offList[0].ToString();
			int i = 1;

			while(i < offList.Count)
			{
				message += "|" + offList[i].ToString();

				i++;
			}

			SendMessage(message);

			int j = 0;

			while (messageReturned == null && j < 1000)
			{
				j++;
			}

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return false;
			}

			return true;
        }

        //서버에 있는 nurse 목록을 가지고 온다.
        public virtual List<Nurse> getNurseList()
        {
            List<Nurse> list = null;
            return list;
        }

        //개인정보 수정한 것을 서버로 보낸다.
        //성공하면 true 실패하면 false
		// id는 개인정보를 수정할 간호사의 id, nurse는 수정된 개인정보
        public virtual bool modifyNurse(string ID, Nurse nurse)
        {
            bool result = false;
            return result;
        }
        
        //서버에 있는 option을 가지고 온다.
        public virtual Option getOption()
        {
            Option result = null;
            return result;
        }
        
        //서버에 option을 저장한다.
        //성공하면 true 실패하면 false
        public virtual bool setOption(Option option)
        {
            bool result = false;
            return result;
        }

		//서버에 schedule을 보낸다.
		//성공하면 true 실패하면 false
		public virtual bool sendMonthSchedule(MonthSchedule schedule)
        {
			string message = "SAVESCH|";
			message += schedule.ToString();

			SendMessage(message);

			int i = 0;

			while (messageReturned == null && i < 1000)
			{
				i++;
			}

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return false;
			}

			return true;
		}

        //서버에 있는 schedule를 가지고 온다.
        //ex) year = 2016 month = 03
        public virtual MonthSchedule getMonthSchedule(string year, string month)
        {
            MonthSchedule result = null;
            return result;
		}

		//ID에 해당하는 nurse 정보를 가지고 온다.
		public virtual Nurse getNurse(string ID)
		{
			Nurse result = null;
			return result;
		}

		//id찾기에 답을 돌려줄 함수
		public virtual Nurse ReturnInfo(string name, string lisenceNumber)
		{
			SendMessage("FINDID," + name + ',' + lisenceNumber);

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

			Nurse result = new Nurse(messageReturned);

			return result;
		}

		//비밀번호 찾기에 답을 들려줄 함수
		public virtual Nurse ReturnInfo(string id, string name, string lisenceNumber)
		{
			SendMessage("FINDPW," + id + ',' + name + ',' + lisenceNumber);

			int i = 0;

			Thread.Sleep(5000);

			if (messageReturned == null)
			{
				MessageBox.Show("전송시간 초과!");

				return null;
			}

			Nurse result = new Nurse(messageReturned);

			return result;
		}

		public virtual bool RegisterNurse(Nurse newNurse)
		{
			return false;
		}

		#endregion

		#endregion
	}
}
