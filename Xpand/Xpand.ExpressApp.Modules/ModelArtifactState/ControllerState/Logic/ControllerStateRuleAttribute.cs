﻿using System;
using Xpand.ExpressApp.ModelArtifactState.ArtifactState.Logic;

namespace Xpand.ExpressApp.ModelArtifactState.ControllerState.Logic {
    public class ControllerStateRuleAttribute : ArtifactStateRuleAttribute, IControllerStateRule {
        public ControllerStateRuleAttribute(string id, Type controllerType, string normalCriteria, string emptyCriteria, ControllerState state) : base(id, normalCriteria, emptyCriteria) {
            ControllerType = controllerType;
            ControllerState = state;
        }
        #region IControllerStateRule Members
        public Type ControllerType { get; set; }
        public ControllerState ControllerState { get; set; }

        #endregion
    }
}