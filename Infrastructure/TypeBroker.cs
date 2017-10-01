using AspNetCoreDependencyInjectionExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjectionExamples.Infrastructure
{
    public static class TypeBroker
    {
        private static Type repoType = typeof(MemoryRepository);
        private static IRepository testRepo;

        //获取一个接口的属性
        public static IRepository Repository =>
            testRepo ?? Activator.CreateInstance(repoType) as IRepository;

        //本质上是设置当前具体的实例
        public static void SetRepositoryType<T>() where T : IRepository =>
            repoType = typeof(T);

        //设置接口
        public static void SetTestObject(IRepository repo)
        {
            testRepo = repo;
        }


    }
}
