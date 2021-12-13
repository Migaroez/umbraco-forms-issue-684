using System;
using System.Collections.Generic;
using System.Linq;
using umbraco.BusinessLogic;
using Umbraco.Core;
using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Enums;
using Umbraco.Forms.Data.Storage;
using Umbraco.Forms.Web.Services;

/// <summary>
/// Summary description for TestWorkflow
/// </summary>
public class UpdateRecordWorkflow : WorkflowType
{
    public UpdateRecordWorkflow()
    {
        this.Id = new Guid("83B6E13A-F704-4813-94A2-A8CCEE2DCE0D");
        this.Name = "Update Record Test";
        this.Description = "Tries to update the record without modifying";
        this.Icon = "icon-chat-active";
        this.Group = "Services";
    }
    public override WorkflowExecutionStatus Execute(Record record, RecordEventArgs e)
    {
        RecordStorage store = new RecordStorage();
        store.UpdateRecord(record, e.Form);
        store.Dispose();

        return WorkflowExecutionStatus.Completed;
    }

    public override List<Exception> ValidateSettings()
    {
        return new List<Exception>();
    }
}