﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum ModelType
    {
        //[ModelTypeInfo("Erdős-Rényi model",
        //    "The classical random network.",
        //    "ERModel.ERNetwork, ERModel")]
        ER,

        //[ModelTypeInfo("Watts-Strogatz model",
        //    "Random network, which represents the small-world property.",
        //    "WSModel.WSNetwork, WSModel")]
        WS,

        //[ModelTypeInfo("Baraba´si-Albert model",
        //    "Random network, which represents the scale-free property.",
        //    "BAModel.BANetwork, BAModel")]
        BA,

        //[ModelTypeInfo("Regular Hierarchical model",
        //    "Random regularly branching block-hierarchical network.",
        //    "RegularHierarchicModel.RegularHierarchicNetwork, RegularHierarchicModel")]
        RegularHierarchic,

        //[ModelTypeInfo("Non Regular Hierarchical model",
        //    "Random non-regularly branching block-hierarchical network.",
        //    "NonRegularHierarchicModel.NonRegularHierarchicNetwork, NonRegularHierarchicModel")]
        NonRegularHierarchic,

        //[ModelTypeInfo("HMN model",
        //    "Random network.",
        //    "HMNModel.HMNetwork, HMNModel")]
        HMN,

        //[ModelTypeInfo("d-regular random model",
        //    "d-regular random network.",
        //    "RegularERModel.RegularERNetwork, RegularERModel")]
        RegularER,

        //[ModelTypeInfo("Cayley tree model",
        //    "Cayley tree model.",
        //    "CalyeyTreeModel.CayleyTreeNetwork, CalyeyTreeModel")]
        CayleyTree
    }
}
