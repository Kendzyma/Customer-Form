using CustomerForm.Model;

namespace CustomerForm.FormService
{
    public interface IFormServices
    {
        bool FormAction(FormSubmissionRequest req);
    }
}