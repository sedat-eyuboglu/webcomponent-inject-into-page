using Microsoft.AspNetCore.Mvc;

public class JsComponentViewComponent : ViewComponent
{
    public JsComponentViewComponent()
    { }
    public async Task<IViewComponentResult> InvokeAsync(string jsClient)
    {
        //Do something with jsClient. For example create a context.
        await Task.CompletedTask;
        var model = new JsViewComponentModel();
        model.ClientId = jsClient;
        return View(model);
    }

}