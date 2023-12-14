namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpperExpressionConveterSchema

	/// <exclude/>
	public class UpperExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpperExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpperExpressionConveterSchema(UpperExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27fcf242-4fd9-4cab-8a03-9f96704724a7");
			Name = "UpperExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,177,10,194,64,12,157,45,244,31,66,39,5,57,112,18,117,84,103,7,117,18,135,107,77,235,65,123,119,36,57,81,212,127,55,213,181,134,183,188,188,151,247,136,183,29,114,180,21,194,1,137,44,135,90,204,58,248,218,53,137,172,184,224,243,236,153,103,163,196,206,55,176,127,176,96,183,82,174,56,237,74,14,45,10,142,139,185,89,152,25,188,96,19,192,7,129,196,8,114,117,12,85,107,153,167,224,188,158,217,203,119,255,167,197,28,99,68,218,222,35,33,179,114,21,111,72,130,84,76,206,218,21,83,217,186,234,151,7,67,86,117,194,114,80,233,67,64,35,250,47,222,121,166,208,249,0,84,199,168,14,246,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27fcf242-4fd9-4cab-8a03-9f96704724a7"));
		}

		#endregion

	}

	#endregion

}

