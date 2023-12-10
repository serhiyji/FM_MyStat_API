using FM_MyStat_API.Core.AutoMappers;
using FM_MyStat_API.Core.AutoMappers.Student;
using FM_MyStat_API.Core.AutoMappers.Users;
using FM_MyStat_API.Core.Interfaces;
using FM_MyStat_API.Core.Services;
using FM_MyStat_API.Core.Services.HomeworkServices;
using FM_MyStat_API.Core.Services.LessonServices;
using FM_MyStat_API.Core.Services.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core
{
    public static class ServiceExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<EmailService>();
            services.AddTransient<UserService>();
            services.AddTransient<StudentService>();
            services.AddTransient<TeacherService>();
            services.AddTransient<AdministratorService>();

            services.AddScoped<ILessonMarkService, LessonMarkService>();
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IHomeworkService,HomeworkService>();
            services.AddScoped<IHomeworkDoneService,HomeworkDoneService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<IGroupService, GroupService>();
        }
        public static void AddMapping(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperAdminProfile));
            services.AddAutoMapper(typeof(AutoMapperStudentProfile));
            services.AddAutoMapper(typeof(AutoMapperTeacherProfile));
            services.AddAutoMapper(typeof(AutoMapperUserProfile));
            services.AddAutoMapper(typeof(AutoMapperHomework));
            services.AddAutoMapper(typeof(AutoMapperHomeworkDone));
            services.AddAutoMapper(typeof(AutoMapperSubjectProfile));
            services.AddAutoMapper(typeof(AutoMapperGroupProfile));
            services.AddAutoMapper(typeof(AutoMapperLessons));
            services.AddAutoMapper(typeof(AutoMapperLessonMark));
        }
    }
}
