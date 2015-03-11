using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            GuestResponse rsvp = new GuestResponse();
//            The TryUpdateModel method performs a process called model binding where data values are used
//from the browser request to populate the properties of our data model object. The other argument to the
//TryUpdateModel method is the object that ASP.NET should use to obtain the values it needs—we have used the
//System.Web.ModelBinding.FormValueProvider class, which provides values from form data. We describe model
//binding in more depth in Part 3, but the result of calling the TryUpdateModel method is that the properties of our
//GuestResponse object are updated to reflect the data values that the user submitted in the form. We then store the
//GuestResponse object in our repository.
            if (TryUpdateModel(rsvp,
            new FormValueProvider(ModelBindingExecutionContext)))
            {
                ResponseRepository.GetRepository().AddResponse(rsvp);
                if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value)
                {
                    Response.Redirect("seeyouthere.html");
                }
                else
                {
                    Response.Redirect("sorryyoucantcome.html");
                }
            }
        }
    }
}