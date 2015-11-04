using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using CharacterManagerService.Models;

namespace CharacterManagerService
{
    [ServiceContract]
    public interface ICharacterManagerService
    {

        [OperationContract]
        string GetData(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<Faction> GetFactions();

        [OperationContract]
        List<Race> GetRaces();

        [OperationContract]
        List<Class> GetClasses();

        [OperationContract]
        List<CharacterData> SubmitCharacterData(CharacterData submitCharacter);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool _boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return _boolValue; }
            set { _boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
