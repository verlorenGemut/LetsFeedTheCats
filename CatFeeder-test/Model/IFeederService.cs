using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IFeederService
    {
        short activateFeeder(string userID, string feederID);
        short updateFeeder(string feederID, string feederName);
    }

}
