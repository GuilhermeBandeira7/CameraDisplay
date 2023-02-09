using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosaicoApp
{
    public class MosaicoController
    {
        #region SINGLETON
        private static MosaicoController instance;
        private MosaicoController()
        {
        }

        public static MosaicoController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MosaicoController();
                }
                return instance;
            }
        }
        #endregion

        public List<string> listRtsp { get; set; } = new List<string>();
    }
}
