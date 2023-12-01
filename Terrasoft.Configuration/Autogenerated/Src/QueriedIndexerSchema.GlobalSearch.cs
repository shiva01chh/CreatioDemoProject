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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,203,110,194,48,16,60,7,137,127,88,169,151,32,33,127,0,168,23,232,67,61,84,165,60,62,192,196,11,88,50,118,234,7,42,66,253,247,110,236,0,73,149,52,23,43,187,51,227,153,93,107,126,68,87,242,2,97,141,214,114,103,118,158,205,141,222,201,125,176,220,75,163,217,171,50,91,174,86,200,109,113,24,14,46,195,65,22,156,212,251,22,222,34,123,214,94,122,137,110,218,9,232,19,156,27,21,142,122,227,165,234,36,54,161,236,77,11,252,166,62,1,9,250,96,113,79,106,48,87,220,185,9,124,6,180,18,69,196,160,141,136,50,108,149,44,160,168,0,127,250,48,129,25,119,120,67,103,151,200,184,139,26,237,188,13,133,55,150,180,23,81,40,33,106,209,182,92,126,181,182,196,175,128,206,63,113,207,103,65,42,65,55,201,222,214,184,210,203,174,212,56,191,243,10,117,147,212,44,142,34,124,2,91,50,158,255,163,218,77,134,11,252,212,25,169,144,98,182,51,191,163,63,24,81,197,181,198,99,225,81,212,137,175,191,96,78,180,24,41,16,78,70,10,168,132,219,230,243,116,0,198,99,12,215,238,71,137,105,245,235,115,137,55,123,173,42,249,139,241,78,252,30,190,10,5,143,208,63,91,22,207,122,21,141,118,158,12,176,141,67,75,155,212,228,158,174,73,227,206,58,175,31,223,60,247,60,78,122,124,206,115,93,32,91,162,138,180,212,116,47,18,149,88,112,239,209,234,209,180,119,163,172,99,90,205,156,137,218,189,161,84,109,23,169,70,223,47,238,202,12,255,189,3,0,0 };
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

