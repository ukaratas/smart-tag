using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace smart_tag
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });

            services.AddSwaggerGen(c =>
             {
                 c.SwaggerDoc("v1", new OpenApiInfo
                 {
                     Title = "Smart Tag",
                     Version = "v1",
                     Description = @"API based item **labeling**  micro services.  
                     .  
                     **Key Fatures**  
                     - Tag any record with just two input: Entity descriptor and item unique id.  
                     - Tags can have user defined properties.
                     - Tags and Items search services are provided.  
                     .  
                     **Main Components**  
                     **1 - Tag:** Tags are labels can attached to anything that has unique identifier (Guid).   
                     **2 - Tag Propeties:** Propetries are typed key value collection for tags. When a tag is attached to item, tag also carry the property values those defined for tag.   
                     **3 - Tag Intances:** Intances are records those loosly coupled connected to tags. Tag instance record just know the unique id of item, type of item and tag propery values.  
                     .  
                     **Common Topics**  
                     .  
                     **GET Method Filter Parameters**  
                     **String Filter**  This filter support exact value, @contains(part of string), @begin-with(starting of String), @end-with*(ending of String) keywords
                     .  
                     .    
                    ",
                 });

                 var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                 var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                 c.IncludeXmlComments(xmlPath);
                 c.EnableAnnotations();

                 c.GeneratePolymorphicSchemas();

                 c.TagActionsBy((api) =>
                 {
                     List<string> returnValue = new List<string>();
                     returnValue.Add("untagged");
                     returnValue.Add("Tag");
                     returnValue.Add("Tag Instance");
                     returnValue.Add("Documents");
                     returnValue.Add("Tag Properties");
                     return returnValue;
                 });


                 
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Smart Documents API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
