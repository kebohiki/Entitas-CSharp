//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public ListArrayComponent listArray { get { return (ListArrayComponent)GetComponent(VisualDebuggingComponentIds.ListArray); } }
        public bool hasListArray { get { return HasComponent(VisualDebuggingComponentIds.ListArray); } }

        public void AddListArray(System.Collections.Generic.List<string>[] newListArray) {
            var component = CreateComponent<ListArrayComponent>(VisualDebuggingComponentIds.ListArray);
            component.listArray = newListArray;
            AddComponent(VisualDebuggingComponentIds.ListArray, component);
        }

        public void ReplaceListArray(System.Collections.Generic.List<string>[] newListArray) {
            var component = CreateComponent<ListArrayComponent>(VisualDebuggingComponentIds.ListArray);
            component.listArray = newListArray;
            ReplaceComponent(VisualDebuggingComponentIds.ListArray, component);
        }

        public void RemoveListArray() {
            RemoveComponent(VisualDebuggingComponentIds.ListArray);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherListArray;

        public static IMatcher ListArray {
            get {
                if(_matcherListArray == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.ListArray);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherListArray = matcher;
                }

                return _matcherListArray;
            }
        }
    }
