using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using TuitionsOnline.Server.DataAccessLayer;
using TuitionsOnline.Shared;

namespace TuitionsOnline.Server.Controllers
{
    
    public class TeachersController : ControllerBase
    {

        ITeacherAccessLayer _teachers;

        public TeachersController(ITeacherAccessLayer teachers)
        {
            _teachers = teachers;
        }

        [HttpPost]
        [Route("api/Teachers/Create")]
        public void Create([FromBody] Teacher teacher)
        {

           


           // //Connecting to Azure Blob Storage
           // var account = new CloudStorageAccount(new StorageCredentials("tuitionsonline", "8rWlY9DW47Aue44sH2lCE2Qo9sUSqDq2+0+yyA5bQRyzOzmAyjZjVOyW/0ts651OkqGFYUIW7hpncOjCjfUO8Q=="), true);
           // var cloudBlobClient = account.CreateCloudBlobClient();
           // var container = cloudBlobClient.GetContainerReference("teacherdocuments");
           // var blob = container.GetBlockBlobReference(teacher.TeachersFullName);
           //// Console.WriteLine(teacher.UploadYourIdentificationDocument);
           // using (var stream = new MemoryStream(teacher.UploadYourIdentificationDocument, writable: true))
           // {
           //     blob.UploadFromStreamAsync(stream);

           // }
           // var blobUrl = blob.Uri.AbsoluteUri;
           // teacher.ApplicationReceivedDate = DateTime.Today;
           // teacher.UploadYourIdentificationDocumentBloburl = blobUrl;
            if (ModelState.IsValid)
                this._teachers.AddTeacher(teacher);
        }
    }
}
