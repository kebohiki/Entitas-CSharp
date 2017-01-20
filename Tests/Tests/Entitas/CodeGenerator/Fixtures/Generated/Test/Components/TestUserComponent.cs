//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;
using Entitas.Api;

public sealed partial class TestEntity : Entity {

    public UserComponent user { get { return (UserComponent)GetComponent(TestComponentIds.User); } }
    public bool hasUser { get { return HasComponent(TestComponentIds.User); } }

    public void AddUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
        var component = CreateComponent<UserComponent>(TestComponentIds.User);
        component.timestamp = newTimestamp;
        component.isLoggedIn = newIsLoggedIn;
        AddComponent(TestComponentIds.User, component);
    }

    public void ReplaceUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
        var component = CreateComponent<UserComponent>(TestComponentIds.User);
        component.timestamp = newTimestamp;
        component.isLoggedIn = newIsLoggedIn;
        ReplaceComponent(TestComponentIds.User, component);
    }

    public void RemoveUser() {
        RemoveComponent(TestComponentIds.User);
    }
}

public sealed partial class TestContext : Context<TestEntity> {

    public TestEntity userEntity { get { return GetGroup(TestMatcher.User).GetSingleEntity(); } }
    public UserComponent user { get { return userEntity.user; } }
    public bool hasUser { get { return userEntity != null; } }

    public TestEntity SetUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
        if(hasUser) {
            throw new EntitasException("Could not set user!\n" + this + " already has an entity with UserComponent!",
                "You should check if the context already has a userEntity before setting it or use context.ReplaceUser().");
        }
        var entity = CreateEntity();
        entity.AddUser(newTimestamp, newIsLoggedIn);
        return entity;
    }

    public void ReplaceUser(System.DateTime newTimestamp, bool newIsLoggedIn) {
        var entity = userEntity;
        if(entity == null) {
            entity = SetUser(newTimestamp, newIsLoggedIn);
        } else {
            entity.ReplaceUser(newTimestamp, newIsLoggedIn);
        }
    }

    public void RemoveUser() {
        DestroyEntity(userEntity);
    }
}

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherUser;

    public static IMatcher<TestEntity> User {
        get {
            if(_matcherUser == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentIds.User);
                matcher.componentNames = TestComponentIds.componentNames;
                _matcherUser = matcher;
            }

            return _matcherUser;
        }
    }
}
