using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Models;
using DataFluentApi;
using NuGet.Frameworks;
using DataFluentApi.Entities;
using System.Reflection;

namespace Tes
{
    [TestFixture]
    public class TestMapper
    {
        
        [Test]
        public void TestTMap()
        {

            Trainer_Detail td = new Trainer_Detail();
            var tm = Mapper.TMap(td);
            Assert.AreEqual(tm.GetType(), typeof(TrainerDetail));

        }
        [Test]
        public void TestEdMap()
        {
            Education_Detail ed=new Education_Detail();
            var vm=Mapper.EdMap(ed);
            Assert.AreEqual(vm.GetType(), typeof(EducationDetail));
        }

        [Test]
        public void TestCmpMap()
        {
            Company_Detail cd = new Company_Detail();
            var vm=Mapper.CmpMap(cd);
            Assert.AreEqual(vm.GetType(),typeof(CompanyDetail));
        }

        [Test]
        public void TestSkillMap() 
        {
            Skill_Set ss=new Skill_Set();
            var s=Mapper.SkillMap(ss);
            Assert.AreEqual(s.GetType(),typeof(SkillSet));
        }

    }
}
