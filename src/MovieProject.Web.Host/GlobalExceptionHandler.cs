using Abp.Dependency;
using Abp.Events.Bus.Exceptions;
using Abp.Events.Bus.Handlers;

namespace MovieProject.Web.Host
{
    public class GlobalExceptionHandler : IEventHandler<AbpHandledExceptionData>, ITransientDependency {
        
        public void HandleEvent(AbpHandledExceptionData eventData)
        {
            var ex = eventData.Exception;
        }
    }
}