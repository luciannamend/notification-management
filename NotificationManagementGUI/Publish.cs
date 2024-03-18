using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationManagementGUI
{
    internal class Publish
    {
        public delegate void PublishContentDel(string content);

        public PublishContentDel PublishContent = null;

        public void SendContent(string content)
        {
            PublishContent.Invoke(content);
        }
    }
}
