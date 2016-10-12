namespace SPAddinTest.Workflows.HR_Intake {
    
    #line 17 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 18 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 19 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 20 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "D:\VS\SPAddinTest\SPAddinTest\Workflows\HR_Intake\Workflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow_TypedDataContext2.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext0 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext1 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext2 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext3 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext4 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext5 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext6 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 2);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext7 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext7.ValueType___Expr7Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow_TypedDataContext2 refDataContext0 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext0.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Workflow_TypedDataContext2 refDataContext1 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext2 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext2.ValueType___Expr2Get();
            }
            if ((expressionId == 3)) {
                Workflow_TypedDataContext2 refDataContext3 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext4 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext4.ValueType___Expr4Get();
            }
            if ((expressionId == 5)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext5 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext5.ValueType___Expr5Get();
            }
            if ((expressionId == 6)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext6 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext7 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext7.ValueType___Expr7Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "OrientationStage") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Title") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "OrientationStage==\"HR paperwork\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "new System.Collections.ObjectModel.Collection<string>() { \"ryansbcho@hotmail.com\"" +
                            " }") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Title + \" is waiting in the lobby to fill out benefits and employment forms.\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Title + \" is ready for HR paperwork\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr7GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1 : Workflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1_ForReadOnly : Workflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2 : Workflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_0 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string OrientationStage {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string Title {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 63 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr0Get() {
                
                #line 63 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(Microsoft.Activities.DynamicValue value) {
                
                #line 63 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                
          dv_0 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 75 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          OrientationStage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 75 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
          OrientationStage;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(string value) {
                
                #line 75 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                
          OrientationStage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 78 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Title;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 78 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
          Title;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 78 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                
          Title = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "dv_0") 
                            || (locationReferences[(offset + 0)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "OrientationStage") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Title") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2_ForReadOnly : Workflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_0 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string OrientationStage {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string Title {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 70 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr2Get() {
                
                #line 70 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 85 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          OrientationStage=="HR paperwork";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr4Get() {
                
                #line 85 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
          OrientationStage=="HR paperwork";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 102 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
              new System.Collections.ObjectModel.Collection<string>() { "ryansbcho@hotmail.com" };
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr5Get() {
                
                #line 102 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
              new System.Collections.ObjectModel.Collection<string>() { "ryansbcho@hotmail.com" };
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 92 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Title + " is waiting in the lobby to fill out benefits and employment forms.";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 92 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
              Title + " is waiting in the lobby to fill out benefits and employment forms.";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 97 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Title + " is ready for HR paperwork";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 97 "D:\VS\SPADDINTEST\SPADDINTEST\WORKFLOWS\HR_INTAKE\WORKFLOW.XAML"
                return 
              Title + " is ready for HR paperwork";
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 0)].Name != "dv_0") 
                            || (locationReferences[(offset + 0)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "OrientationStage") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Title") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
