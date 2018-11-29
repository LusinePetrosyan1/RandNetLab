using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core1;

namespace LabSessionManager
{
    public static class LabSessionManager
    {
        private static AbstractResearch existingResearch;

        public static Guid CreateResearch()
        {
            return new Guid();
        }

        public static Guid CloneResearch()
        {
            return new Guid();
        }

        public static void StartResearch(Guid id)
        {

        }

        public static void StopResearch(Guid id)
        {

        }

        public static Core.ResearchType GetResearchType()
        {
            return Core.ResearchType.Activation;
        }

        public static string GetResearchName(Guid id)
        {
            return "";
        }

        public static void SetResearchName(Guid id, String s)
        {

        }

        public static List<Core.ModelType> GetAvailableModelTypes(Guid id)
        {
            return new List<Core.ModelType>();
        }

        public static List<Core.ModelType> GetAvailableModelTypes(Core.ResearchType rt)
        {
            return new List<Core.ModelType>();
        }

        private static List<Core.ModelType> AvailableModelTypes(Type t)
        {
            return new List<Core.ModelType>();
        }

        public static Core.ModelType GetResearchModelType(Guid id)
        {
            return Core.ModelType.BA;
        }

        public static void SetResearchModelType(Guid id, Core.ModelType modelType)
        {

        }

        public static Core.ResearchStatusInfo GetResearchStatus(Guid id)
        {
            return new Core.ResearchStatusInfo();
        }

        public static int GetProcessStepsCount(Guid id)
        {
            return 0;
        }

        public static List<Core.ResearchParameter> GetRequiredResearchParameters(Core.ResearchType rt)
        {
            return new List<Core.ResearchParameter>();
        }

        public static Dictionary<Core.ResearchParameter, object> GetResearchParameterValues(Guid id)
        {
            return new Dictionary<Core.ResearchParameter, object>();
        }

        public static void SetResearchParameterValue(Guid id, Core.ResearchParameter p, object value)
        {

        }

        public static Core.AnalyzeOption GetAvailableAnalyzeOptions(Guid id)
        {
            return Core.AnalyzeOption.Algorithm_1_By_All_Nodes;
        }

        public static Core.AnalyzeOption GetAvailableAnalyzeOptions(Core.ResearchType rt, Core.ModelType mt)
        {
            return Core.AnalyzeOption.Algorithm_1_By_All_Nodes;
        }

        public static Core.AnalyzeOption GetAnalyzeOptions(Guid id)
        {
            return Core.AnalyzeOption.Algorithm_1_By_All_Nodes;
        }

        public static void SetAnalyzeOptions(Guid id, Core.AnalyzeOption o)
        {

        }




    }
}
