<template>
    <form>
        <div class="form-group">
            <label for="account">帳號：</label>
            <input type="text" class="form-control" id="account" placeholder="輸入帳號">
        </div>
        <div class="form-group">
            <label for="name">名字：</label>
            <input type="text" class="form-control" id="name" placeholder="輸入名字">
        </div>
        <div class="form-group">
            <label>角色：</label><br>
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="role" id="teacher" value="teacher">
                <label class="form-check-label" for="teacher">教師</label>
            </div>
            <div class="form-check form-check-inline">
                <input class="form-check-input" type="radio" name="role" id="parent" value="parent">
                <label class="form-check-label" for="parent">家長</label>
            </div>
        </div>
        <div class="form-group button-group">
            <button type="submit" class="btn btn-primary">送出</button>
            <button type="button" class="btn btn-secondary">取消</button>
        </div>
    </form>
</template>



<style scoped>
.button-group {
    display: flex;
    gap: 15px;
}
</style>