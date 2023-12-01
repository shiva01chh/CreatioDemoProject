namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorElementSchema

	/// <exclude/>
	public class ColumnValuesIteratorElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorElementSchema(ColumnValuesIteratorElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e");
			Name = "ColumnValuesIteratorElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,79,195,48,12,134,207,171,212,255,96,149,11,92,154,59,116,149,80,197,129,195,164,29,16,119,47,117,187,136,38,169,226,116,128,16,255,157,44,105,39,168,38,114,138,191,30,219,175,13,106,226,17,37,193,11,57,135,108,59,95,54,214,116,170,159,28,122,101,77,217,160,30,81,245,134,243,236,43,207,242,108,115,227,168,15,1,104,6,100,190,135,198,14,147,54,175,56,76,196,207,158,66,149,117,79,3,105,50,62,166,11,33,160,226,73,107,116,159,245,108,63,30,216,59,148,30,40,37,66,103,93,72,34,2,233,168,219,22,215,152,133,168,203,5,39,126,241,198,233,48,40,9,184,32,229,121,172,255,167,218,164,69,46,155,236,200,31,109,27,118,217,71,86,10,174,231,142,142,29,190,17,67,104,115,46,123,87,254,8,26,165,179,12,167,216,9,208,180,32,99,235,217,83,94,80,98,205,170,70,116,168,193,132,11,108,11,105,141,167,15,95,212,77,250,68,69,70,103,37,49,43,211,47,66,113,89,137,88,22,41,235,213,79,86,181,176,79,69,183,215,20,88,224,115,183,187,135,89,7,50,109,146,34,218,223,233,204,127,156,193,23,222,15,19,139,8,65,46,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e"));
		}

		#endregion

	}

	#endregion

}

