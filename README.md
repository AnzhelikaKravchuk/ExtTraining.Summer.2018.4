## Комментарии

1. Был изменен интерфейс метода VerifyPassword класса PasswordCheckerService для возможность использовать подключаемую валидацию через интерфейс IValidatable и подключаемый репозиторий через интерфейс IRepository. С помощью класса ValidatorComposite можно создать комбинацию условий валидации и так же использовать ее в методе.

