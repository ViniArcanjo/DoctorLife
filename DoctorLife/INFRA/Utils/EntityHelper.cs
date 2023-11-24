using DoctorLife.DL.Base;

namespace DoctorLife.INFRA.Utils
{
    public static class EntityHelper
    {
        public static void UpsertAuditInfo(EntityAuditBase entity, bool insert = true)
        {
            entity.IsActive = 'Y';
            entity.ModifiedAt = DateTime.Now;
            entity.ModifiedBy = "System";

            if (insert)
            {
                entity.CreatedAt = DateTime.Now;
                entity.CreatedBy = "System";
            }
        }
    }
}
