using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWebService
    {

        [OperationContract]
        string GetData (int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract (CompositeType composite);

        // TODO: Add your service operations here
        
        /// <summary>
        /// Get Single User using id
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [OperationContract]
        DAL.User GetUser(int userid);






    }





    // Use a data contract as illustrated in the sample below to add composite types to service operations.


    //[DataContract]
    //public class User
    //{
    //    [DataMember]
    //    public int Id { get; set; }
    //    [DataMember]
    //    public string UserName { get; set; }
    //    [DataMember]
    //    public string Email { get; set; }
    //}


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
