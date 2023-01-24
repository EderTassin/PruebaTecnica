using AsistenciaPersonal.DAO.Interface;
using AsistenciaPersonal.DTO;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistenciaPersonal.DAO
{
    public class PersonalDAO : IPersonalDAO 
    {

        private readonly IConfiguration _config;

        public PersonalDAO(IConfiguration config) 
        {
            _config = config;
        }

        public List<PersonalDTO> GetPersonal()
        {
            try
            {
                string? connectionString = _config["ConnectionString"];

                using SqlConnection connection = new(connectionString);
                using SqlCommand command = connection.CreateCommand();

                connection.ConnectionString = connectionString;
                command.Parameters.Clear();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_SelectAsistenciaPersonal";
                command.Connection = connection;

                DataSet response = new DataSet();

                using (SqlDataAdapter objSqlDataAdapter = new(command))
                {
                    objSqlDataAdapter.Fill(response);
                }

                var config = new MapperConfiguration(cfg => cfg.CreateMap<DataRow, PersonalDTO>()
                    .ForMember(dest => dest.IdPersona, opts => opts.MapFrom(src => src["id"]))
                    .ForMember(dest => dest.Nombre, opts => opts.MapFrom(src => src["nombre"]))
                    .ForMember(dest => dest.Apellido, opts => opts.MapFrom(src => src["apellido"]))
                    .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src["email"]))
                    .ForMember(dest => dest.Asistencia, opts => opts.MapFrom(src => src["asistencia"]))
                    .ForMember(dest => dest.FechaModificacion, opts => opts.MapFrom(src => src["fecha_modificacion"]))
                );


                return config.CreateMapper().Map<List<PersonalDTO>>(response.Tables[0].Rows)
                    .OrderBy(item => item.Apellido).ToList();

            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
           

        }
    }
}
