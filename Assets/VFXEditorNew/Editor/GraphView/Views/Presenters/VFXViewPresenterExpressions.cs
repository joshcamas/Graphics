using System;
using System.Collections.Generic;
using UIElements.GraphView;
using UnityEngine;

using Object = UnityEngine.Object;

namespace UnityEditor.VFX.UI
{
    partial class VFXViewPresenter : GraphViewPresenter
    {
        public event System.Action onRecompileEvent;
        public void RecomputeExpressionGraph(VFXModel model, VFXModel.InvalidationCause cause)
        {
            if (cause != VFXModel.InvalidationCause.kStructureChanged &&
                cause != VFXModel.InvalidationCause.kConnectionChanged &&
                cause != VFXModel.InvalidationCause.kExpressionInvalidated &&
                cause != VFXModel.InvalidationCause.kParamChanged)
                return;

            //Debug.Log("------------------------ RECOMPUTE EXPRESSION CONTEXT");
            CreateExpressionContext(cause == VFXModel.InvalidationCause.kStructureChanged || cause == VFXModel.InvalidationCause.kConnectionChanged);
            m_ExpressionContext.Recompile();

            if (onRecompileEvent != null)
            {
                onRecompileEvent();
            }
        }

        private void CreateExpressionContext(bool forceRecreation)
        {
            if (!forceRecreation && m_ExpressionContext != null)
                return;

            m_ExpressionContext = new VFXExpression.Context();
            HashSet<Object> currentObjects = new HashSet<Object>();
            m_GraphAsset.root.CollectDependencies(currentObjects);

            int nbExpr = 0;
            foreach (var o in currentObjects)
            {
                if (o is VFXSlot)
                {
                    var exp = ((VFXSlot)o).GetExpression();
                    if (exp != null)
                        {
                        m_ExpressionContext.RegisterExpression(exp);
                            ++nbExpr;
                        }
                }
            }

            //Debug.Log("")
        }

        public bool CanGetEvaluatedContent(VFXSlot slot)
        {
            if (m_ExpressionContext == null)
                return false;

            var reduced = m_ExpressionContext.GetReduced(slot.GetExpression());
            return reduced.Is(VFXExpression.Flags.Value);
        }

        public object GetEvaluatedContent(VFXSlot slot)
        {
            if (!CanGetEvaluatedContent(slot))
                return null;

            var reduced = m_ExpressionContext.GetReduced(slot.GetExpression());
            return reduced.GetContent();
        }

        private VFXExpression.Context m_ExpressionContext;
    }
}
