﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Security.Permissions
{
    public sealed partial class SiteIdentityPermission : System.Security.CodeAccessPermission
    {
        public SiteIdentityPermission(System.Security.Permissions.PermissionState state) { }
        public SiteIdentityPermission(string site) { }
        public string Site { get; set; }
        public override System.Security.IPermission Copy() { return default(System.Security.IPermission); }
        public override void FromXml(SecurityElement esd) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { return default(System.Security.IPermission); }
        public override bool IsSubsetOf(System.Security.IPermission target) { return false; }
        public override SecurityElement ToXml() { return default(SecurityElement); }
        public override System.Security.IPermission Union(System.Security.IPermission target) { return default(System.Security.IPermission); }
    }
}
