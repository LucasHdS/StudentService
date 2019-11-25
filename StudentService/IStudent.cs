using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IStudent
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                UriTemplate="getStudents",
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Wrapped,
                RequestFormat = WebMessageFormat.Json)]
        List<Student> GetStudents();

        [OperationContract]
        [WebInvoke(UriTemplate="createStudent", 
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat =WebMessageFormat.Json,
                Method = "POST",
                BodyStyle = WebMessageBodyStyle.Wrapped)]
        void CreateStudent(Student student);

        [OperationContract]
        [WebInvoke(UriTemplate = "updateStudent", 
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                Method = "PUT",
                BodyStyle = WebMessageBodyStyle.Wrapped)]
        void UpdateStudent(Student student);

        [OperationContract]
        [WebInvoke(UriTemplate = "deleteStudent/{id}", 
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                Method ="DELETE",
                BodyStyle = WebMessageBodyStyle.Bare)]
        void DeleteStudent(string id);
        // TODO: Adicione suas operações de serviço aqui
    }

}
