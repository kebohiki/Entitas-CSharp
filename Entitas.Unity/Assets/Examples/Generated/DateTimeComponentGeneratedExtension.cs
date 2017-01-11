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

        public DateTimeComponent dateTime { get { return (DateTimeComponent)GetComponent(VisualDebuggingComponentIds.DateTime); } }
        public bool hasDateTime { get { return HasComponent(VisualDebuggingComponentIds.DateTime); } }

        public void AddDateTime(System.DateTime newDate) {
            var component = CreateComponent<DateTimeComponent>(VisualDebuggingComponentIds.DateTime);
            component.date = newDate;
            AddComponent(VisualDebuggingComponentIds.DateTime, component);
        }

        public void ReplaceDateTime(System.DateTime newDate) {
            var component = CreateComponent<DateTimeComponent>(VisualDebuggingComponentIds.DateTime);
            component.date = newDate;
            ReplaceComponent(VisualDebuggingComponentIds.DateTime, component);
        }

        public void RemoveDateTime() {
            RemoveComponent(VisualDebuggingComponentIds.DateTime);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherDateTime;

        public static IMatcher DateTime {
            get {
                if(_matcherDateTime == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.DateTime);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherDateTime = matcher;
                }

                return _matcherDateTime;
            }
        }
    }
