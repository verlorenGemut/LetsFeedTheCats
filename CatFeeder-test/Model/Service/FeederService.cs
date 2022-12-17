using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model.Service
{
    public class FeederService : IFeederService
    {
        private IRepository<Feeder> feederRepository;
        private IRepository<User> userRepository;
        /*public FeederService(IRepository<Feeder> feederRepository, IRepository<User> userRepository) //check for repository injection
        {
            this.feederRepository = feederRepository;
            this.userRepository = userRepository;
        }*/

        public short activateFeeder(string userID, string feederID)
        {
            Feeder newFeeder = new Feeder(feederID, "");
            if (feederID == "")
                return 0;
            else
            {
                newFeeder.strUserID = userID;
                string cond = "feeder_id = '" + feederID + "'";
                feederRepository.addFeederToDatabase(newFeeder);
                return 1;
            };
        }

        public short updateFeeder(string feederID, string feederName) 
        {
			if (feederName == "")
				return 0;

			Feeder feeder = new Feeder(feederID, feederName);
            feeder.strName = feederName;
            string cond = "feeder_id = '"+feederID+"';";
            feederRepository.updateFeederInDatabase(feeder, cond);

            return 1;
        }


    }
}


