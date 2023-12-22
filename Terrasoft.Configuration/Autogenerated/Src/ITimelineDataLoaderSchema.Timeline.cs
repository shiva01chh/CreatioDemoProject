namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITimelineDataLoaderSchema

	/// <exclude/>
	public class ITimelineDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITimelineDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITimelineDataLoaderSchema(ITimelineDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64fda8d7-1a00-44a6-879f-e69e891738f1");
			Name = "ITimelineDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ef55f699-c757-427c-a5d6-6f8a0d355b0a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,203,78,196,48,12,60,111,165,254,131,85,46,32,161,246,3,40,61,44,32,132,180,39,216,31,8,169,91,89,74,156,146,199,161,66,252,59,73,211,174,22,237,94,200,205,158,153,140,199,102,161,209,77,66,34,28,209,90,225,204,224,235,39,195,3,141,193,10,79,134,235,35,105,84,196,88,22,223,101,177,11,142,120,132,143,217,121,212,145,168,20,202,196,114,245,43,50,90,146,15,101,17,89,55,22,199,216,133,183,77,252,44,188,56,24,209,163,93,240,166,105,160,117,65,107,97,231,110,173,19,236,96,19,64,31,21,48,24,11,110,66,73,3,73,64,246,228,231,122,147,55,103,250,41,124,170,200,32,246,104,135,20,230,170,241,46,5,184,240,254,175,249,165,123,238,76,194,10,13,28,247,249,88,101,118,213,189,100,85,219,44,224,117,174,92,182,93,117,39,115,21,103,129,220,253,163,60,144,243,237,222,4,238,55,106,254,190,91,166,79,65,111,55,96,97,101,116,157,252,254,20,238,29,191,2,58,159,143,188,250,220,229,179,253,228,227,33,247,249,126,169,140,189,243,247,11,33,228,182,110,48,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64fda8d7-1a00-44a6-879f-e69e891738f1"));
		}

		#endregion

	}

	#endregion

}

