using AutoMapper;
using Ex7_Bartosz_Sadowski.Dto;
using Ex7_Bartosz_Sadowski.Models;

namespace Ex7_Bartosz_Sadowski.Profiles
{
    public class CarProfile :Profile
    {

        public CarProfile()
        {
            CreateMap<Car, CarDto>()
                .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
                .ForMember(d => d.Car, o => o.MapFrom(s => $"{s.Company.ToUpper()} {s.Model.ToUpper()} {s.YearOfProduction}"))
                .ForMember(d => d.MaxSpeed, o => o.MapFrom(s => $"{s.Vmax} {s.Unit.ToUpper()}"))
                .ForMember(d => d.IsHybrid, o => o.MapFrom(s => s.IsHybrid == true ? "Prawda" : "Fałsz"))
                .ForMember(d => d.Rating, o => o.MapFrom(s => $"{s.Stars}/10"))
                .ForMember(d => d.Price, o => o.MapFrom(s => $"{s.Price} {s.Currency.ToUpper()}"))
                .ForMember(d => d.Description, o => o.MapFrom(s => s.Description));
                
        }

    }
}
