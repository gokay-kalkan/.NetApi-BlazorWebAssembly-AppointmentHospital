using AppointmentHospital.Client;
using AppointmentHospital.Client.Services.ForAuth;
using AppointmentHospital.Client.Services.ForDoctor;
using AppointmentHospital.Client.Services.ForMeet;
using AppointmentHospital.Client.Services.ForPoliclinic;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7221/") });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IPoliclinicService, PoliclinicService>();
builder.Services.AddScoped<IMeetService, MeetService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

builder.Services.AddAuthorizationCore();
builder.Services.AddOptions();
await builder.Build().RunAsync();
