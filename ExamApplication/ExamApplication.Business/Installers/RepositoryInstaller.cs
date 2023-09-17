﻿using ExamApplication.Data.Repository;
using ExamApplication.Data.Repository.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExamApplication.Business.Installers;

public class RepositoryInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepositoryAsync<>), typeof(RepositoryBase<>));
        services.AddScoped<IGradeRepository, GradeRepository>();
        services.AddScoped<ILessonRepository, LessonRepository>();
        services.AddScoped<IPupilRepository, PupilRepository>();
        services.AddScoped<ITeacherRepository, TeacherRepository>();
        services.AddScoped<IExamRepository, ExamRepository>();

    }
}