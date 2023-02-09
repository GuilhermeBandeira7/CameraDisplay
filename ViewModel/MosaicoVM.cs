using EntityMtwServer.Entities;
using MosaicoApp.Pages;
using MosaicoApp.ViewModel.Command;
using MTWServerApiClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Xml.Serialization;
using Vlc.DotNet.Wpf;

namespace MosaicoApp.ViewModel
{
    public class MosaicoVM : INotifyPropertyChanged
    {

		public ChangeUserControlCommand changeUserControl{ get; set; }

        public ObservableCollection<string> rtspList { get;private set; } 
            = new ObservableCollection<string>()
        {
             /*   #region LocalRtsp
                "rtsp://admin:Mtw@12345@172.16.2.55:554",
                "rtsp://admin:Mtw@12345@172.16.2.56:554",
                "rtsp://admin:Mtw@12345@172.16.2.57:554",
                "rtsp://admin:Mtw@12345@172.16.2.58:554",
                "rtsp://admin:Mtw@12345@172.16.2.59:554",
                "rtsp://admin:Mtw@12345@172.16.2.60:554",
                "rtsp://admin:Mtw@12345@172.16.2.61:554",
                "rtsp://admin:Mtw@12345@172.16.2.62:554",
                "rtsp://admin:Mtw@12345@172.16.2.63:554",
                "rtsp://admin:Mtw@12345@172.16.2.64:554",
                "rtsp://admin:Mtw@12345@172.16.2.65:554",
                "rtsp://admin:Mtw@12345@172.16.2.66:554",
                "rtsp://admin:Mtw@12345@172.16.2.67:554",
                "rtsp://admin:Mtw@12345@172.16.2.68:554",
                "rtsp://admin:Mtw@12345@172.16.2.69:554"
                #endregion   */        
            };

        #region Pages 

        private Page currentPage;

		public Page CurrentPage
		{
			get { return currentPage; }
			set 
			{ 
				currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));               
			}
		}
      

        private Page lastPage;

        public Page LastPage
        {
            get { return lastPage; }
            set 
            { 
                lastPage = value; 
                OnPropertyChanged(nameof(LastPage));
            }
        }


        private Page2x2 page2x2;

		public Page2x2 Page2x2
		{
			get { return page2x2; }
			set { 
				page2x2 = value;
                OnPropertyChanged(nameof(Page2x2));
            }
		}

		private Page3x3 page3x3;

		public Page3x3 Page3x3
		{
			get { return page3x3; }
			set { 
				page3x3 = value;
                OnPropertyChanged(nameof(Page3x3));
            }
		}

		private Page4x4 page4X4;

		public Page4x4 Page4X4
		{
			get { return page4X4; }
			set 
			{ 
				page4X4 = value;
                OnPropertyChanged(nameof(Page4X4));
            }
		}

		private Page5x5 page5x5;

		public Page5x5 Page5x5
		{
			get { return page5x5; }
			set 
			{ 
				page5x5 = value;
                OnPropertyChanged(nameof(Page5x5));
            }
		}

		private Page6x6 page6x6;

		public Page6x6 Page6x6
		{
			get { return page6x6; }
			set 
			{ 
				page6x6 = value; 
				OnPropertyChanged(nameof(Page6x6));
			}
		}

		private Page7x7 page7x7;

		public Page7x7 Page7x7
		{
			get { return page7x7; }
			set 
			{
				page7x7 = value; 
				OnPropertyChanged(nameof(Page7x7));
			}
		}

        #endregion

        private User user = new User();
        public User User
        {
            get{return user;}
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }


        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                User = new User()
                {
                    Login = username,
                    Password = this.Password
                };

                OnPropertyChanged("Username");
            }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                User = new User()
                {
                    Login = this.Username,
                    Password = password
                };

                OnPropertyChanged("Password");
            }
        }

        public LoginCommand loginCommand { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler Authenticated;

        public MosaicoVM()
		{
            loginCommand = new LoginCommand(this);
            changeUserControl = new ChangeUserControlCommand(this);
        }

		public void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

        public async void Login()
        {
            try
            {
                UserClient userClient = new UserClient();
                //SessionClient<Session> sessionClient = new SessionClient<Session>();
                User loggedUser = (User)await userClient.Read(Username, Password);
                if (loggedUser != null)
                {
                    if (loggedUser.Id > 0)
                    {
                        User = loggedUser;        
                        EquipmentClient equipmentClient = new EquipmentClient();
                        User.Equipments = (await equipmentClient.Read(loggedUser.Id)).Cast<Equipment>().ToList();
                        Authenticated?.Invoke(this, new EventArgs());
                        GetUserEquipments();                       
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        ObservableCollection<Equipment> userEquipment = new ObservableCollection<Equipment>();

        private void GetUserEquipments()
        {
            if(user.Equipments!= null)
            {
                foreach (Equipment equipment in User.Equipments)
                {
                   userEquipment.Add(equipment);
                }

                AddUserRTSPToList();
            }            
        }

        private void AddUserRTSPToList()
        {
            for (int i = 0; i < userEquipment.Count; i++)
            {
                if (!userEquipment[i].PrimaryStreamingRtsp.Equals(""))
                {
                    rtspList.Add(userEquipment[i].PrimaryStreamingRtsp);
                }
            }

            AddToSingleton();
        }

        private void AddToSingleton()
        {
            foreach(string rtsp in rtspList)
            {
                MosaicoController.Instance.listRtsp.Add(rtsp.Replace("127.0.0.1","10.1.1.31"));
            }
        }


        public string DisplaySelectedCamera(string name)
        {
            if (name.Equals("CameraDisplay1"))
            {
                return rtspList.First();
            }
            else if (name.Equals("CameraDisplay2"))
            {
                return rtspList.ElementAt(1);
            }
            else if (name.Equals("CameraDisplay3"))
            {
                return rtspList.ElementAt(2);
            }
            else if (name.Equals("CameraDisplay4"))
            {
                return rtspList.ElementAt(3);
            }
            else if (name.Equals("CameraDisplay5"))
            {
                return rtspList.ElementAt(4);
            }
            else if (name.Equals("CameraDisplay6"))
            {
                return rtspList.ElementAt(5);
            }
            else if (name.Equals("CameraDisplay7"))
            {
                return rtspList.ElementAt(6);
            }
            else if (name.Equals("CameraDisplay8"))
            {
                return rtspList.ElementAt(7);
            }
            else if (name.Equals("CameraDisplay9"))
            {
                return rtspList.Last();
            }
            return "";
        }
    }
}
