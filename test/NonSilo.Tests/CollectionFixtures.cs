﻿using TestExtensions;
using UnitTests.Serialization;
using Xunit;

namespace NonSilo.Tests
{
    // Assembly collections must be defined once in each assembly
    [CollectionDefinition("DefaultCluster")]
    public class DefaultClusterTestCollection : ICollectionFixture<DefaultClusterFixture> { }


    [CollectionDefinition(TestEnvironmentFixture.DefaultCollection)]
    public class TestEnvironmentFixtureCollection : ICollectionFixture<TestEnvironmentFixture>, ICollectionFixture<BuiltInSerializerCollectionFixture> { }
}