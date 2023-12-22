namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueriedIndexerSchema

	/// <exclude/>
	public class QueriedIndexerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueriedIndexerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueriedIndexerSchema(QueriedIndexerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5329f48a-37fa-49fb-9285-1a0aa78ae731");
			Name = "QueriedIndexer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,203,110,194,48,16,60,7,137,127,88,169,151,32,33,127,0,168,23,232,67,61,84,165,60,62,192,196,11,88,50,118,106,175,81,17,234,191,215,177,3,36,85,210,92,172,236,206,140,103,118,173,249,17,93,201,11,132,53,90,203,157,217,17,155,27,189,147,123,111,57,73,163,217,171,50,91,174,86,200,109,113,24,14,46,195,65,230,157,212,251,22,222,34,123,214,36,73,162,155,118,2,250,4,231,70,249,163,222,144,84,157,196,38,148,189,105,129,223,161,31,128,1,250,96,113,31,212,96,174,184,115,19,248,244,104,37,138,136,65,27,17,165,223,42,89,64,81,1,254,244,97,2,51,238,240,134,206,46,145,113,23,53,218,145,245,5,25,27,180,23,81,40,33,106,209,182,92,126,181,182,196,47,143,142,158,56,241,153,151,74,132,155,100,111,107,92,233,101,87,106,156,223,121,133,186,73,106,22,71,17,62,129,109,48,158,255,163,218,77,134,11,252,212,25,67,33,197,108,103,126,71,58,24,81,197,181,134,176,32,20,117,226,235,47,152,83,88,140,20,8,39,35,5,84,194,109,243,121,58,0,227,49,134,107,247,163,196,180,250,245,185,196,155,189,86,53,248,139,241,78,252,30,190,10,5,143,208,63,91,22,207,122,21,141,118,158,12,176,141,67,27,54,169,131,251,112,77,26,119,214,121,253,248,230,185,231,113,134,199,231,136,235,2,217,18,85,164,165,166,123,145,168,196,130,19,161,213,163,105,239,70,89,199,180,154,57,19,181,123,67,169,218,46,134,90,243,251,5,105,66,90,239,198,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5329f48a-37fa-49fb-9285-1a0aa78ae731"));
		}

		#endregion

	}

	#endregion

}

