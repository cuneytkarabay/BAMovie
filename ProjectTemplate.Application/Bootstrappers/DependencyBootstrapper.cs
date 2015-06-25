using System.Data.Entity;
using ProjectTemplate.Business;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.EF;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.IoC;
using ProjectTemplate.Core.Repository;
using ProjectTemplate.Repository;
using ProjectTemplate.Service;

namespace ProjectTemplate.Application.Bootstrappers
{
    /// <summary>
    /// Dependency bootstrapper
    /// </summary>
    public class DependencyBootstrapper : IBootstrapper
    {
        /// <summary>
        /// Bootstraps dependencies
        /// </summary>
        /// <param name="dependencyContainer"></param>
        public virtual void Bootstrap(IDependencyContainer dependencyContainer)
        {
           
        
            dependencyContainer.RegisterTransient<IUnitOfWork, EFUnitOfWork>();
            dependencyContainer.RegisterTransient<IRepository, EFRepository>();
            dependencyContainer.RegisterTransient<DbContext, ProjectTemplateContext>();


            dependencyContainer.RegisterTransient<IServiceBase<Student>, ServiceBase<Student>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Student>, RepositoryBase<Student>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Student>, BusinessBase<Student>>();

            dependencyContainer.RegisterTransient<IServiceStudent, ServiceStudent>();
            dependencyContainer.RegisterTransient<IRepositoryStudent, RepositoryStudent>();
            dependencyContainer.RegisterTransient<IBusinessStudent, BusinessStudent>();


            dependencyContainer.RegisterTransient<IServiceBase<Firm>, ServiceBase<Firm>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Firm>, RepositoryBase<Firm>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Firm>, BusinessBase<Firm>>();
            dependencyContainer.RegisterTransient<IServiceFirm, ServiceFirm>();
            dependencyContainer.RegisterTransient<IRepositoryFirm, RepositoryFirm>();
            dependencyContainer.RegisterTransient<IBusinessFirm, BusinessFirm>();

            dependencyContainer.RegisterTransient<IServiceBase<User>, ServiceBase<User>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<User>, RepositoryBase<User>>();
            dependencyContainer.RegisterTransient<IBusinessBase<User>, BusinessBase<User>>();
            dependencyContainer.RegisterTransient<IServiceUser, ServiceUser>();
            dependencyContainer.RegisterTransient<IRepositoryUser, RepositoryUser>();
            dependencyContainer.RegisterTransient<IBusinessUser, BusinessUser>();

            dependencyContainer.RegisterTransient<IServiceBase<Actor>, ServiceBase<Actor>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Actor>, RepositoryBase<Actor>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Actor>, BusinessBase<Actor>>();
            dependencyContainer.RegisterTransient<IServiceActor, ServiceActor>();
            dependencyContainer.RegisterTransient<IRepositoryActor, RepositoryActor>();
            dependencyContainer.RegisterTransient<IBusinessActor, BusinessActor>();

            dependencyContainer.RegisterTransient<IServiceBase<Director>, ServiceBase<Director>>();
            dependencyContainer.RegisterTransient<IRepositoryBase<Director>, RepositoryBase<Director>>();
            dependencyContainer.RegisterTransient<IBusinessBase<Director>, BusinessBase<Director>>();
            dependencyContainer.RegisterTransient<IServiceDirector, ServiceDirector>();
            dependencyContainer.RegisterTransient<IRepositoryDirector, RepositoryDirector>();
            dependencyContainer.RegisterTransient<IBusinessDirector, BusinessDirector>();

        }
    }
}
