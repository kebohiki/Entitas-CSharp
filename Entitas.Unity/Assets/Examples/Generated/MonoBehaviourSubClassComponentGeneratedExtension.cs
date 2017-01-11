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

        public MonoBehaviourSubClassComponent monoBehaviourSubClass { get { return (MonoBehaviourSubClassComponent)GetComponent(VisualDebuggingComponentIds.MonoBehaviourSubClass); } }
        public bool hasMonoBehaviourSubClass { get { return HasComponent(VisualDebuggingComponentIds.MonoBehaviourSubClass); } }

        public void AddMonoBehaviourSubClass(MonoBehaviourSubClass newMonoBehaviour) {
            var component = CreateComponent<MonoBehaviourSubClassComponent>(VisualDebuggingComponentIds.MonoBehaviourSubClass);
            component.monoBehaviour = newMonoBehaviour;
            AddComponent(VisualDebuggingComponentIds.MonoBehaviourSubClass, component);
        }

        public void ReplaceMonoBehaviourSubClass(MonoBehaviourSubClass newMonoBehaviour) {
            var component = CreateComponent<MonoBehaviourSubClassComponent>(VisualDebuggingComponentIds.MonoBehaviourSubClass);
            component.monoBehaviour = newMonoBehaviour;
            ReplaceComponent(VisualDebuggingComponentIds.MonoBehaviourSubClass, component);
        }

        public void RemoveMonoBehaviourSubClass() {
            RemoveComponent(VisualDebuggingComponentIds.MonoBehaviourSubClass);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherMonoBehaviourSubClass;

        public static IMatcher MonoBehaviourSubClass {
            get {
                if(_matcherMonoBehaviourSubClass == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.MonoBehaviourSubClass);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherMonoBehaviourSubClass = matcher;
                }

                return _matcherMonoBehaviourSubClass;
            }
        }
    }
