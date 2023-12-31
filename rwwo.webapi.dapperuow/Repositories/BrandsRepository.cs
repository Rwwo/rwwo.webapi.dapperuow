using Dapper;
using Npgsql;
using rwwo.webapi.dapperuow.DTOs;
using rwwo.webapi.dapperuow.Interfaces;
using rwwo.webapi.dapperuow.Models;

namespace rwwo.webapi.dapperuow.Repositories
{
    public class BrandsRepository : IBrand
    {
        private readonly NpgsqlConnection _connection;
        public BrandsRepository(IConfiguration configuration)
        {
            _connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public async Task<IEnumerable<Brand>> Get()
        {
            var sql = $@"SELECT id
                               ,nome
                               ,create_date
                               ,update_date
                               ,delete_date
                              FROM
                                marcas
                                where delete_date is null
                                ";

            return await _connection.QueryAsync<Brand>(sql);
        }
        public async Task<Brand> Find(Guid id)
        {
            var sql = $@"SELECT id
                               ,nome
                               ,create_date
                               ,update_date
                               ,delete_date
                          FROM
                                marcas
                          WHERE
                                id=@id";

            return await _connection.QueryFirstOrDefaultAsync<Brand>(sql, new { id });
        }
        public async Task<Brand> Add(BrandInputModel input)
        {
            Brand model = new Brand();

            model.id = Guid.NewGuid();
            model.create_date = DateTime.Now;
            model.nome = input.nome;

            var sql = $@"INSERT INTO marcas
                               (id,
                                nome,
                                create_date)
                         VALUES
                               (@id,
                                @nome,
                                @create_date)";

            await _connection.ExecuteAsync(sql, model);
            return model;
        }
        public async Task<Brand> Update(BrandUpdateModel input)
        {
            Brand model = new Brand();

            model.id = input.id;
            model.nome = input.nome;
            model.update_date = DateTime.Now;
            var sql = $@"UPDATE marcas
                        SET
                            nome = @nome,
                            update_date =@update_date
                        WHERE
                            id=@id";

            await _connection.ExecuteAsync(sql, model);
            return model;
        }
        public async Task<int> Remove(Brand model)
        {
            model.delete_date = DateTime.Now;
            var sql = $@"
                        UPDATE marcas
                        SET
                            delete_date =@delete_date
                        WHERE
                            id=@id";

            return await _connection.ExecuteAsync(sql, model);
        }
    }
}
