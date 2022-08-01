create procedure [dbo].[spTodos_CompleteTodo]
	@AssignedTo int,
	@TodoId int
as
begin
	update dbo.Todos
	set IsComplete = 1
	where Id = @TodoId
		and AssignedTo = @AssignedTo;
end