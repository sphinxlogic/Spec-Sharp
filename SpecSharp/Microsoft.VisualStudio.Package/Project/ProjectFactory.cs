//-----------------------------------------------------------------------------
//
// Copyright (C) Microsoft Corporation.  All Rights Reserved.
//
//-----------------------------------------------------------------------------
using System;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.Shell;
using System.Runtime.InteropServices;
using System.Reflection; // to retrieve version info....

using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

namespace Microsoft.VisualStudio.Package {
	/// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory"]/*' />
	/// <summary>
	/// Implement this abstract base class and provide the project type Guid and 
	/// the CreateProject methods.
	/// </summary>
	[CLSCompliant(false)]
	public abstract class ProjectFactory : IVsProjectFactory {
        /// <include file='doc\EditorFactory.uex' path='docs/doc[@for="ProjectFactory.package;"]/*' />
        protected Microsoft.VisualStudio.Shell.Package package;

        /// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory.site;"]/*' />
        protected IServiceProvider site;

        /// <include file='doc\EditorFactory.uex' path='docs/doc[@for="ProjectFactory.ProjectFactory"]/*' />
        public ProjectFactory() {
//            this.site = package;
        }

        /// <include file='doc\EditorFactory.uex' path='docs/doc[@for="ProjectFactory.SetPackage"]/*' />
        public void SetPackage(Microsoft.VisualStudio.Shell.Package package) {
            this.package = package;
        }

		/// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory.CreateProject"]/*' />
		protected abstract Project CreateProject();

        #region IVsProjectFactory methods
		/// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory.CanCreateProject"]/*' />
		public virtual int CanCreateProject(string filename, uint flags, out int canCreate) {
			canCreate = 1;
      return 0;
		}

		/// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory.Close"]/*' />
		public virtual int Close() {
			this.site = null;
      return 0;
		}

		/// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory.IVsProjectFactory.CreateProject"]/*' />
		/// <internalonly/>
		int IVsProjectFactory.CreateProject(string filename, string location, string name, uint flags, ref Guid iidProject, out IntPtr ptrProject, out int canceled) {
			Project project = CreateProject();

      project.SetSite((IOleServiceProvider)this.site);
			project.Load(filename, location, name, flags, ref iidProject, out canceled);
			ptrProject = Marshal.GetIUnknownForObject(project);
      return 0;
		}

		/// <include file='doc\ProjectFactory.uex' path='docs/doc[@for="ProjectFactory.SetSite"]/*' />
		public virtual int SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider site) {
			this.site = new ServiceProvider(site);
      return 0;
		}
    #endregion 
	}
} // namespace end
