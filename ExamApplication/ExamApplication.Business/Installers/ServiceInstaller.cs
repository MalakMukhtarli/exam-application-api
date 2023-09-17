using ExamApplication.Business.Services.Grades;
using ExamApplication.Business.Services.Lessons;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamApplication.Business.Installers;

public class ServiceInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IGradeService, GradeManager>();
        services.AddScoped<ILessonService, LessonManager>();
        
    }
}