
# Firebase for Schema

A custom package for Schema that allows you to use Firebase in your unity projects.


## Features

- Firebase config scriptable object 
- FirebaseManager Singleton for easy access
- Login / UploadResult / AddUserToExam


## Use

```
  - Create a FirebaseConfig scriptable object in your project.
  - Fill the FirebaseConfig data.
  - Within your managers add a FirebaseManager component.
  - Add as a reference the previously created FirebaseConfig.
```
    
## API Reference

#### User Authentication

```csharp
  Login()
```

| Parameter   | Type                   | Description                                            |
|:------------|:-----------------------|:-------------------------------------------------------|
| `email`     | `string`               | **Required**. Your user email                          |
| `password`  | `string`               | **Required**. Your user password                       |
| `email`     | `string`               | **Required**. Your user email                          |
| `onSuccess` | `Action<AuthResponse>` | **Required**. Callback to be called in case of success |
| `onFailed`  | `Action<Exception>`    | **Required**. Callback to be called in case of failure |


Logs in the user with the given email and password.

#### Exam management

```csharp
  UploadResult()
```

| Parameter   | Type                | Description                                            |
|:------------|:--------------------|:-------------------------------------------------------|
| `userId`    | `string`            | **Required**. User's localId provided by firebase      |
| `data`      | `Result`            | **Required**. User's result data                       |
| `examId`    | `string`            | **Required**. ExamId that the user is partaking        |
| `idToken`   | `string`            | **Required**. User's idToken provided by firebase      |
| `onSuccess` | `Action<Result>`    | **Required**. Callback to be called in case of success |
| `onFailed`  | `Action<Exception>` | **Required**. Callback to be called in case of failure |


Uploads the test result to firebase database.

```csharp
  AddUserToExam()
```

| Parameter   | Type                | Description                                            |
|:------------|:--------------------|:-------------------------------------------------------|
| `userId`    | `string`            | **Required**. User's localId provided by firebase      |
| `timestamp` | `double`            | **Required**. Time of exam                             |
| `examId`    | `string`            | **Required**. ExamId that the user is partaking        |
| `idToken`   | `string`            | **Required**. User's idToken provided by firebase      |
| `onFailed`  | `Action<Exception>` | **Required**. Callback to be called in case of failure |


Links the test result to the user in the firebase database.
## Usage/Examples

```csharp
var _fm = FirebaseManager.instance;

_fm.Login("email@test.oco", "password", onSuccess, onFailed);

_fm.UploadResult(_user.localId, data, examId, _user.idToken, OnSimulationAdded, OnRequestFailed);

_fm.AddUserToExam(_user.localId, _dateTimestamp, GetExamId(), _user.idToken, OnRequestFailed);

```


## Authors

- [@NoVvaN](https://www.github.com/novvan)

