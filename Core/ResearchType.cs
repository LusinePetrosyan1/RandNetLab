using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum ResearchType
    {
        //[ResearchTypeInfo("Basic research",
        //    "The basic analysis for random networks (Double ensemble).",
        //    "Research.BasicResearch, Research")]
        Basic,

        //[ResearchTypeInfo("Evolution research",
        //    "Analysis the evolution of trajectories for random networks (several ensembles).",
        //    "Research.EvolutionResearch, Research")]
        Evolution,

        //[ResearchTypeInfo("Threshold research",
        //    "Analysis of Threshold probability (critical probability) for random network (several ensembles).",
        //    "Research.ThresholdResearch, Research")]
        Threshold,

        //[ResearchTypeInfo("Collection of researches",
        //    "",
        //    "Research.CollectionResearch, Research")]
        Collection,

        //[ResearchTypeInfo("Structural research",
        //    "",
        //    "Research.StructuralResearch, Research")]
        Structural,

        //[ResearchTypeInfo("Activation research",
        //    "",
        //    "Research.ActivationResearch, Research")]
        Activation
    }
}
