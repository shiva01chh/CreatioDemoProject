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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,203,78,196,48,12,60,111,165,254,131,85,46,32,161,246,3,40,61,0,43,132,180,39,216,31,8,169,91,89,106,156,110,30,135,10,241,239,228,209,174,64,187,23,114,179,103,38,227,177,89,40,180,179,144,8,71,52,70,88,61,184,250,89,243,64,163,55,194,145,230,250,72,10,39,98,44,139,175,178,216,121,75,60,194,199,98,29,170,64,156,38,148,145,101,235,87,100,52,36,31,202,34,176,110,12,142,161,11,111,155,248,69,56,113,208,162,71,147,240,166,105,160,181,94,41,97,150,110,173,35,108,97,19,64,31,20,48,104,3,118,70,73,3,73,64,118,228,150,122,147,55,191,244,179,255,156,2,131,216,161,25,98,152,171,198,187,24,224,194,251,191,230,151,238,185,51,11,35,20,112,216,231,99,149,217,85,183,207,170,182,73,224,117,174,76,219,174,186,179,249,20,102,129,220,253,163,60,144,117,237,147,246,220,111,212,252,125,151,166,143,65,111,55,32,177,50,186,78,126,127,14,247,142,39,143,214,229,35,175,62,119,249,108,223,249,120,200,125,190,95,44,67,47,190,31,45,183,137,55,40,2,0,0 };
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

