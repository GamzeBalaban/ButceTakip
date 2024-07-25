
using Butce.BusinessLayer.Concrete;
using Butce.DataAccessLayer.Concrete;
using Butce.DataAccessLayer.Abstract;
using Butce.BusinessLayer.Abstract;
using Butce.DataAccessLayer.EntityFramework;
using System.Reflection;
using ButceTakipApi.Hubs;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});
builder.Services.AddSignalR();
    

// Add services to the container.
builder.Services.AddDbContext<BudgetContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IRolesService,RolesManager>();
builder.Services.AddScoped<IRolesDal, EfRolesDal>();


builder.Services.AddScoped<IProxyService, ProxyManager>();
builder.Services.AddScoped<IProxyDal, EfProxyDal>();


builder.Services.AddScoped<IExpensesService, ExpensesManager>();
builder.Services.AddScoped<IExpensesDal, EfExpensesDal>();

builder.Services.AddScoped<IWorkDoneService, WorkDoneManager>();
builder.Services.AddScoped<IWorkDoneDal, EfWorkDoneDal>();

builder.Services.AddScoped<IWorkDoneTypeService, WorkDoneTypeManager>();
builder.Services.AddScoped<IWorkDoneTypeDal, EfWorkDoneTypeDal>();

builder.Services.AddScoped<IVATService, VATManager>();
builder.Services.AddScoped<IVATDal, EfVATDal>();

builder.Services.AddScoped<IAddUserService, AddUserManager>();
builder.Services.AddScoped<IAddUserDal, EfAddUserDal>();

builder.Services.AddScoped<ILevelsService, LevelsManager>();
builder.Services.AddScoped<ILevelsDal, EfLevelsDal>();

builder.Services.AddScoped<IRefuseService, RefuseManager>();
builder.Services.AddScoped<IRefuseDal, EfRefuseDal>();



builder.Services.AddScoped<ISubLevelsService, SubLevelsManager>();
builder.Services.AddScoped<ISubLevelsDal, EfSubLevelsDal>();

builder.Services.AddScoped<ICompanyNameService, CompanyNameManager>();
builder.Services.AddScoped<ICompanyNameDal, EfCompanyNameDal>();


builder.Services.AddScoped<IAppControlService, AppControlManager>();
builder.Services.AddScoped<IAppControlDal, EfAppControlDal>();

builder.Services.AddScoped<IBudgetService, BudgetManager>();
builder.Services.AddScoped<IBudgetDal, EfBudgetDal>();

builder.Services.AddScoped<IAppControlService, AppControlManager>();
builder.Services.AddScoped<IAppControlDal, EfAppControlDal>();

builder.Services.AddScoped<IPlanningService, PlanningManager>();
builder.Services.AddScoped<IPlanningDal, EfPlanningDal>();


builder.Services.AddScoped<IRealizationService, RealizationManager>();
builder.Services.AddScoped<IRealizationDal, EfRealizationDal>();


builder.Services.AddScoped<IApprovalService, ApprovalManager>();
builder.Services.AddScoped<IApprovalDal, EfApprovalDal>();

builder.Services.AddScoped<IBudgetAmountService, BudgetAmountManager>();
builder.Services.AddScoped<IBudgetAmountDal, EfBudgetAmountDal>();










builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHub<SignalRHub>("/signalrhub");

app.Run();
