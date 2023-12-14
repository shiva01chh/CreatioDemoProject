﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillWebhookServiceSchema

	/// <exclude/>
	public class MandrillWebhookServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillWebhookServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillWebhookServiceSchema(MandrillWebhookServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c0f3a33-410b-4bf8-b03b-13e2539c8348");
			Name = "MandrillWebhookService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,203,75,204,77,45,46,72,76,78,85,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,74,44,201,204,207,211,243,77,204,75,41,202,204,201,9,78,45,42,203,76,78,229,229,170,230,229,170,229,229,226,229,2,1,0,222,65,172,56,63,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c0f3a33-410b-4bf8-b03b-13e2539c8348"));
		}

		#endregion

	}

	#endregion

}

