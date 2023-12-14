namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncomingMessageNotifierSchema

	/// <exclude/>
	public class IIncomingMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncomingMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncomingMessageNotifierSchema(IIncomingMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce1c4ef7-b936-4dd7-987d-b5980c9beea9");
			Name = "IIncomingMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,193,78,195,48,12,134,207,173,212,119,176,186,203,184,180,247,81,42,33,78,149,24,160,137,23,200,90,183,139,212,56,85,156,14,77,136,119,167,75,155,110,108,2,113,128,220,226,252,254,253,57,113,72,40,228,78,148,8,175,104,140,96,93,219,228,65,83,45,155,222,8,43,53,37,207,138,100,185,19,68,216,38,107,100,22,141,164,38,10,223,163,48,10,131,133,193,102,16,65,65,22,77,61,216,172,160,40,168,212,106,208,140,98,124,210,86,214,18,141,211,167,105,10,25,247,74,9,115,200,167,253,6,59,131,140,100,25,164,183,129,90,27,32,151,73,13,180,146,45,18,26,6,177,213,189,5,194,55,80,163,123,226,77,211,51,215,174,223,182,178,60,115,251,158,41,24,250,8,230,54,214,104,119,186,226,21,188,56,7,135,124,197,236,2,247,85,197,142,195,179,37,179,52,189,212,102,157,48,66,1,13,87,125,23,123,125,156,79,44,39,135,44,117,66,151,183,215,178,58,22,121,156,14,151,151,45,248,131,57,253,230,246,7,220,13,42,189,71,254,87,218,177,198,31,1,79,47,116,34,230,223,34,79,131,17,231,190,254,60,42,87,196,174,200,193,131,241,114,30,111,223,236,148,233,73,23,72,213,56,41,110,255,49,126,129,47,193,33,118,92,159,187,60,87,230,87,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce1c4ef7-b936-4dd7-987d-b5980c9beea9"));
		}

		#endregion

	}

	#endregion

}

