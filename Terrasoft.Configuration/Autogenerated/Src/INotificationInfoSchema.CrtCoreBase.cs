namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoSchema

	/// <exclude/>
	public class INotificationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoSchema(INotificationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aee85563-7cba-4466-bec1-e9df72ba319c");
			Name = "INotificationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,93,110,194,48,16,132,159,65,226,14,123,2,114,0,170,74,253,19,138,212,242,0,244,0,38,222,132,69,216,70,246,230,33,66,189,123,215,6,84,42,72,139,137,18,43,63,158,249,50,35,39,86,25,12,59,85,33,44,209,123,21,92,205,227,23,103,107,106,90,175,152,156,29,13,247,163,225,160,13,100,27,88,116,129,209,76,228,90,246,162,40,224,33,180,198,40,223,61,30,175,75,203,232,235,232,86,59,15,100,101,52,201,5,92,13,188,70,176,142,169,166,42,221,27,159,76,138,51,151,93,187,218,82,37,210,147,81,57,59,147,148,226,40,147,226,27,93,240,211,141,37,241,22,251,96,151,180,65,96,31,131,29,100,123,104,144,39,16,226,240,21,159,246,98,158,157,238,242,41,73,117,59,164,212,104,127,172,79,56,50,170,193,30,206,180,37,13,101,156,80,234,12,208,28,43,231,53,208,145,135,30,220,106,131,21,103,36,76,228,55,145,115,151,133,94,84,107,52,10,172,172,194,252,62,15,188,131,197,44,58,228,119,43,89,111,77,247,129,33,92,109,182,23,242,170,24,65,89,13,76,89,241,162,110,25,37,115,52,100,117,58,189,149,121,254,181,192,214,41,29,19,74,55,127,55,249,158,38,222,217,225,239,245,169,49,48,217,127,219,148,95,201,147,150,116,159,150,56,131,57,245,174,221,221,185,92,146,246,106,70,57,82,167,178,125,3,157,184,236,92,16,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aee85563-7cba-4466-bec1-e9df72ba319c"));
		}

		#endregion

	}

	#endregion

}

