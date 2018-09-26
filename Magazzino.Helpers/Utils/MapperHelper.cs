using System;
using AutoMapper;
using Magazzino.Data.Entities;
using Magazzino.Models;


namespace Magazzino.Helpers.Utils
{
    public class MapperHelper
    {
        static MapperHelper _instance;

        MapperHelper()
        {
            Mapper.Initialize(conf =>
            {
               // conf.CreateMap<User, UserViewModel>().ForMember(i=> i.maria, if. );
                conf.CreateMap<Product, ProductViewModel>();
                conf.CreateMap<Customer, CustomerViewModel>();
                conf.CreateMap<Sales, SalesViewModel>();
                conf.CreateMap<Seller, SellerViewModel>();
                conf.CreateMap<User, UserViewModel>();


            });
        }

        public static MapperHelper Instance
        {
            get{
                if(_instance == null)
                {
                    _instance = new MapperHelper();
                }

                return _instance;
            }
        }

        public To Map<From, To>(From obj)
        {
            return Mapper.Map<To>(obj);
        }

        public To Map<From, To>(From from, To to)
        {
            return Mapper.Map(from, to);
        }
    }
}
