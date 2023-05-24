using System.ComponentModel.DataAnnotations;

namespace Lesson.DataAccess.Entity
{
    public class User
    {
        //GUID (Globally Unique Identifier) и ID (Identifier) - это оба способа идентификации объектов, но они имеют несколько отличий.
        //GUID - это уникальный идентификатор, который генерируется компьютером и используется для идентификации объектов в распределенной системе.
        //GUID имеет фиксированный размер 128 бит и представляется в виде 32-значной шестнадцатеричной строки.Он может быть использован для создания
        //уникальных идентификаторов для объектов в базе данных или в других приложениях, которые требуют уникальной идентификации.

        //С другой стороны, ID - это обычно уникальный идентификатор, который используется для идентификации
        //объекта в пределах одного приложения или базы данных. ID может быть строкой, целым числом или другим типом данных,
        //который используется для уникальной идентификации объекта. ID обычно является сгенерированным значением,
        //которое может быть автоматически создано базой данных при вставке новой записи.

        [MaxLength(85)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(85)]
        public string Email { get; set; }

        [Required]
        [MaxLength(85)]
        public string FullName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(85)]
        public string PasswordHash { get; set; }

        public byte[] Filebase64 { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }

        //Свойство public virtual ICollection<T> { get; set; } внутри сущностей Entity Framework представляет навигационное свойство, которое используется
        //для описания отношений между сущностями в базе данных.
        //Например, если у нас есть сущности "User" и "Comment", то мы можем определить отношение
        //"один ко многим" между ними: один User может иметь много Comment, а каждый Comment может принадлежать только к одному User.
        //Для описания этого отношения в сущности "User" мы можем добавить навигационное свойство ICollection<Comment>
    }
}
