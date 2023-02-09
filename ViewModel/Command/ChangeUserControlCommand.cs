using MosaicoApp.Pages;
using MosaicoApp.Usercontrols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace MosaicoApp.ViewModel.Command
{
    public class ChangeUserControlCommand : ICommand
    {
        public MosaicoVM mosaicoVM { get; set; }

        public ChangeUserControlCommand(MosaicoVM mosaicoVM)
        {
            this.mosaicoVM = mosaicoVM;

        }
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            try
            {
                Button buttonPressed = parameter as Button;
                DisplaySelectedPage(buttonPressed);
            }
            catch(Exception ex) { }

        }

        private void DisplaySelectedPage(Button buttonPressed)
        {

            if (buttonPressed.Name.Equals("twoXtwo"))
            {
                try
                {
                    mosaicoVM.LastPage = mosaicoVM.CurrentPage;
                    if (mosaicoVM.Page2x2 == null)
                    {
                        mosaicoVM.Page2x2 = new Page2x2();
                    }
                    mosaicoVM.CurrentPage = mosaicoVM.Page2x2;
                    StopVideosLastPage(mosaicoVM.LastPage);
                    StartVideosCurrentPage(mosaicoVM.CurrentPage);
                }
                catch(InvalidOperationException ioExcpeption)
                {
                    Console.WriteLine(ioExcpeption.Message);
                    Console.WriteLine(ioExcpeption.StackTrace);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else if (buttonPressed.Name.Equals("threeXthree"))
            {
                try
                {                  
                    mosaicoVM.LastPage = mosaicoVM.CurrentPage;
                    if (mosaicoVM.Page3x3 == null)
                    {
                        mosaicoVM.Page3x3 = new Page3x3();
                    }
                    mosaicoVM.CurrentPage = mosaicoVM.Page3x3;
                    StopVideosLastPage(mosaicoVM.LastPage);
                    StartVideosCurrentPage(mosaicoVM.CurrentPage);
                }
                catch (Exception ex)
                {

                }
            }
            else if (buttonPressed.Name.Equals("fourXfour"))
            {
                try
                {
                    mosaicoVM.LastPage = mosaicoVM.CurrentPage;
                    if (mosaicoVM.Page4X4 == null)
                    {
                        mosaicoVM.Page4X4 = new Page4x4();
                    }
                    mosaicoVM.CurrentPage = mosaicoVM.Page4X4;
                    StopVideosLastPage(mosaicoVM.LastPage);
                    StartVideosCurrentPage(mosaicoVM.CurrentPage);
                }
                catch (Exception ex)
                {

                }
            }
            else if (buttonPressed.Name.Equals("fiveXfive"))
            {
                try
                {
                    mosaicoVM.LastPage = mosaicoVM.CurrentPage;
                    if (mosaicoVM.Page5x5 == null)
                    {
                        mosaicoVM.Page5x5 = new Page5x5();
                    }
                    mosaicoVM.CurrentPage = mosaicoVM.Page5x5;
                    StopVideosLastPage(mosaicoVM.LastPage);
                    StartVideosCurrentPage(mosaicoVM.CurrentPage);
                }
                catch(Exception ex)
                {

                }
            }
            else if (buttonPressed.Name.Equals("sixXsix"))
            {
                try
                {
                    mosaicoVM.LastPage = mosaicoVM.CurrentPage;
                    if (mosaicoVM.Page6x6 == null)
                    {
                        mosaicoVM.Page6x6 = new Page6x6();
                    }
                    mosaicoVM.CurrentPage = mosaicoVM.Page6x6;
                    StopVideosLastPage(mosaicoVM.LastPage);
                    StartVideosCurrentPage(mosaicoVM.CurrentPage);
                }
                catch(Exception ex)
                {

                }
            }
            else if (buttonPressed.Name.Equals("sevenXseven"))
            {
                try
                {
                    mosaicoVM.LastPage = mosaicoVM.CurrentPage;
                    if (mosaicoVM.Page7x7 == null)
                    {
                        mosaicoVM.Page7x7 = new Page7x7();
                    }
                    mosaicoVM.CurrentPage = mosaicoVM.Page7x7;
                    StopVideosLastPage(mosaicoVM.LastPage);
                    StartVideosCurrentPage(mosaicoVM.CurrentPage);
                }
                catch(Exception ex)
                {

                }                              
            }
        }

        private void StartVideosCurrentPage(Page currentPage)
        {
            if (currentPage == mosaicoVM.Page2x2)
            {
                mosaicoVM.Page2x2.StartVideos();
            }
            else if (currentPage == mosaicoVM.Page3x3)
            {
                mosaicoVM.Page3x3.StartVideos();
            }
            else if (currentPage == mosaicoVM.Page4X4)
            {
                mosaicoVM.Page4X4.StartVideos();
            }
            else if(currentPage == mosaicoVM.Page5x5)
            {
                mosaicoVM.Page5x5.StartVideos();
            }
            else if(currentPage == mosaicoVM.Page6x6)
            {
                mosaicoVM.Page6x6.StartVideos();
            }
            else if(currentPage == mosaicoVM.Page7x7)
            {
                mosaicoVM.Page7x7.StartVideos();
            }
        }

        private void StopVideosLastPage(Page lastPage)
        {
            if(lastPage != null)
            {
                if (lastPage == mosaicoVM.Page2x2)
                {
                    mosaicoVM.Page2x2.StopVideos();
                }
                else if (lastPage == mosaicoVM.Page3x3)
                {
                    mosaicoVM.Page3x3.StopVideos();
                }
                else if(lastPage == mosaicoVM.Page4X4)
                {
                    mosaicoVM.Page4X4.StopVideos();
                }
                else if(lastPage == mosaicoVM.Page5x5)
                {
                    mosaicoVM.Page5x5.StopVideos();
                }
                else if(lastPage == mosaicoVM.Page6x6)
                {
                    mosaicoVM.Page6x6.StopVideos();
                }
                else if(lastPage == mosaicoVM.Page7x7)
                {
                    mosaicoVM.Page7x7.StopVideos();
                }
            }          
        }
    }
}
