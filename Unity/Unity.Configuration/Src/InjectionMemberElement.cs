﻿using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity.Configuration.ConfigurationHelpers;

namespace Microsoft.Practices.Unity.Configuration
{
    /// <summary>
    /// Base class for configuration elements that generate <see cref="InjectionMember"/>
    /// object to configure a container.
    /// </summary>
    public abstract class InjectionMemberElement : DeserializableConfigurationElement
    {
        /// <summary>
        /// Each element must have a unique key, which is generated by the subclasses.
        /// </summary>
        public abstract string Key { get; }

        /// <summary>
        /// Return the set of <see cref="InjectionMember"/>s that are needed
        /// to configure the container according to this configuration element.
        /// </summary>
        /// <param name="container">Container that is being configured.</param>
        /// <param name="fromType">Type that is being registered.</param>
        /// <param name="toType">Type that <paramref name="fromType"/> is being mapped to.</param>
        /// <param name="name">Name this registration is under.</param>
        /// <returns>One or more <see cref="InjectionMember"/> objects that should be
        /// applied to the container registration.</returns>
        public abstract IEnumerable<InjectionMember> GetInjectionMembers(IUnityContainer container, Type fromType, Type toType, string name);
    }
}