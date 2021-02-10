using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Generic constraint
    //class: referans tip olabilir
    //IEntity: T IENtitiy olabilir veya IEntity imlemente eden nesne olabilir
    //new(); newlwnwbilir.bunun sayesinde IEntity i kullanamayız.Bunu sağladık
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {//Iproductdal ve ICategotyDal ın yapacağı işleri generic classta tutyoruz
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
